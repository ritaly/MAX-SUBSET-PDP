using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZP_Max_PDP
{
    public partial class Algo1 : MetroFramework.Controls.MetroUserControl
    {
        private List<int> _multiset;
        private List<multiSet> _solution;

        public Algo1(List<multiSet> fromMultiset)
        {
            _multiset = new List<int>(); // przechowuje kopię multizbioru jako listę intów,  anie obiektów
            foreach (multiSet o in fromMultiset)
            {
                _multiset.Add(item: o.elementOfmultiSet);
            }

            InitializeComponent();
        }

        private void Algo1_Load(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            sizeElements.Text = _multiset.Count().ToString();
        }

        List<int> bestSolution = new List<int>(); //tu bedzie najlepsze
        List<int> currentSolution; //najlepsze w danym restarcie  
        bool[] is_deleted;

        private void startClimbing_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = progressBar.Minimum;
            progressBar.Maximum = Convert.ToInt32(rangeRestart.Value);

            System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew(); //start zegara 
            var restarts_time = 0.0; // zegar dla poszczególnych restartów

            int minValue = 0;
            int maxValue = _multiset.Count;
            int restarts = Convert.ToInt32(rangeRestart.Value) + 1;
            Random randomValue = new Random();


            while (restarts != 0)
            {
                System.Diagnostics.Stopwatch restart_timer = System.Diagnostics.Stopwatch.StartNew();
                currentSolution = new List<int>();
                is_deleted = Enumerable.Repeat(false, _multiset.Count).ToArray();
                int id = randomValue.Next(minValue: minValue, maxValue: maxValue); // first max value id
                int x = _multiset[id];
                //MessageBox.Show(String.Join(" ", _multiset));
                bool is_end = false;
                is_end = FindSolution(x, id, currentSolution);

                if (is_end)
                {
                    //MessageBox.Show("here");
                    restarts--;
                }
                progressBar.Value += 1;
                progressBar.Update();
                restart_timer.Stop();
                restarts_time += restart_timer.ElapsedMilliseconds;
                timerLabel.Text = (restarts_time * 0.001).ToString();
                timerLabel.Update();
                //MessageBox.Show(String.Join(" ", bestSolution));
            }
            stopwatch.Stop();
            progressBar.Value += 1;
            timerLabel.Text = (stopwatch.ElapsedMilliseconds * 0.001).ToString();
            MessageBox.Show("Skończone");
            sizeSolution.Text = bestSolution.Count().ToString();
            solution_Grid.Visible = true;

            _solution = new List<multiSet>();

            foreach (int o in bestSolution)
            {
                _solution.Add(new multiSet { elementOfmultiSet = o });
            }
            solution_Grid.DataSource = _solution;
        }

        public bool FindSolution(int x, int id, List<int> current)
        {
            int max = x;
            current.Add(x);

            //wygeneruj mozliwe odległości
            List<int> current_multiset = new List<int>(current);
            for (int i = 0; i < current.Count; i++)
            {
                foreach (int item in current.Skip(i + 1).ToList())
                {
                    current_multiset.Add(Math.Abs(current[i] - item));
                }
            }
            bool is_valid = CanBeSolution(current_multiset);

            if (!is_valid)
            {
                return true;
            }

            is_deleted[id] = true;

            int neighbor_id = FindNeighbor(id);

            if (_multiset[neighbor_id] > max)
            {
                //nowy max
                bestSolution = (current.Count >= bestSolution.Count) ? current : bestSolution;
                x = _multiset[neighbor_id];
                return FindSolution(x, neighbor_id, current);
            }
            else
            {
                //jednak mniejsze lub równe to nie szukamy dalej
                bestSolution = (current.Count > bestSolution.Count) ? current : bestSolution;
                return true;
            }

        }

        public bool CanBeSolution(List<int> current_multiset)
        {
            //string s = "restart " + restarts + "zawartosc: " + String.Join(",", current_multiset) + "\n" + String.Join(",", _multiset) + " \n" + !current_multiset.Except(_multiset).Any();
            //MessageBox.Show(s);
            return !current_multiset.Except(_multiset).Any();
        }

        public int FindNeighbor(int id)
        {
            int prev_id = (id == 0) ? id : FindPrevious(id, is_deleted);
            int next_id = (id == _multiset.Count() - 1) ? id : FindNext(id, is_deleted);
            int prev = _multiset[prev_id];
            int next = _multiset[next_id];
            int neighbor_id = (prev > next) ? prev_id : next_id;
            return neighbor_id;
        }

        public int FindPrevious(int start, bool[] deleted)
        {
            int i = start;
            while (i > 0)
            {
                if (deleted[i])
                {
                    i--;
                }
                else
                {
                    break;
                }
            }
            return i;
        }
        public int FindNext(int start, bool[] deleted)
        {
            int i = start;
            while (i < deleted.Count())
            {
                if (deleted[i])
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            i = (i != deleted.Count()) ? i : start;
            return i;
        }

    }
}
