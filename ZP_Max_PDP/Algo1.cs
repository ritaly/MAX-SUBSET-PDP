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
        private List<multiSet> finalSolution;

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

        private List<int> bestSolution = new List<int>(); //tu bedzie najlepsze
        
        List<int> currentSolution; //najlepsze w danym restarcie  
        bool[] isDeleted;

        private void startClimbing_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = progressBar.Minimum;
            progressBar.Maximum = Convert.ToInt32(rangeRestart.Value);
            int minValue = 0;
            int maxValue = _multiset.Count;
            int restarts = Convert.ToInt32(rangeRestart.Value) + 1;
            double partialTime = 0.0; // zegar dla poszczególnych restartów

            Random randomValue = new Random();

            System.Diagnostics.Stopwatch globalTimer = System.Diagnostics.Stopwatch.StartNew(); //start zegara 
            while (restarts != 0)
            {
                System.Diagnostics.Stopwatch restartTimer = System.Diagnostics.Stopwatch.StartNew();

                currentSolution = new List<int>();
                isDeleted = Enumerable.Repeat(false, _multiset.Count).ToArray();
                int idx = randomValue.Next(minValue: minValue, maxValue: maxValue); // first max value id
                int x = _multiset[idx];
                bool isEnd = false;
                isEnd = FindSolution(x, idx, currentSolution);

                if (isEnd)
                {
                    bestSolution = (currentSolution.Count > bestSolution.Count) ? currentSolution : bestSolution;
                    sizeSolution.Text = bestSolution.Count().ToString();
                    restarts--;
                }

                progressBar.Value += 1;
                progressBar.Update();
                restartTimer.Stop();
                partialTime += restartTimer.ElapsedMilliseconds;
                timerLabel.Text = (partialTime * 0.001).ToString();
                timerLabel.Update();
            }

            globalTimer.Stop();
            progressBar.Value += 1;
            timerLabel.Text = (globalTimer.ElapsedMilliseconds * 0.001).ToString();
            MessageBox.Show("Skończone");
            sizeSolution.Text = bestSolution.Count().ToString();
            solution_Grid.Visible = true;

            finalSolution = new List<multiSet>();

            foreach (int o in bestSolution)
            {
                finalSolution.Add(new multiSet { elementOfmultiSet = o });
            }
            solution_Grid.DataSource = finalSolution;
        }

        public bool FindSolution(int x, int id, List<int> current)
        {
            int max = x;
            current.Add(x);

            //wygeneruj mozliwe odległości
            List<int> currentMultiset = new List<int>(current);
            for (int i = 0; i < current.Count; i++)
            {
                foreach (int item in current.Skip(i + 1).ToList())
                {
                    currentMultiset.Add(Math.Abs(current[i] - item));
                }
            }
            bool is_valid = CanBeSolution(currentMultiset);

            if (!is_valid)
            {
                current.RemoveAt(current.Count - 1);
                return true;
            }
            else
            {
                isDeleted[id] = true;
                int neighborId = FindNeighbor(id);
                currentSolution = current;
                
                if (_multiset[neighborId] > max)
                {
                    //nowy max
                    x = _multiset[neighborId];
                    return FindSolution(x, neighborId, current);
                }
                else
                {
                    //jednak mniejsze lub równe to nie szukamy dalej
                    currentSolution = current;
                    return true;
                }
            }

        }

        public bool CanBeSolution(List<int> currentMultiset)
        {
            string s = "current: " + String.Join(" ", currentMultiset) + "\n M: " + String.Join(" ", _multiset) + "\n " + (!currentMultiset.Except(_multiset).Any()).ToString();
            MessageBox.Show(s);
            return !currentMultiset.Except(_multiset).Any(); // z wyjątkiem tego co w multizbiorze
        }

        public int FindNeighbor(int id)
        {
            int prevId = (id == 0) ? id : FindPrevious(id, isDeleted);
            int nextId = (id == _multiset.Count() - 1) ? id : FindNext(id, isDeleted);
            int prev = _multiset[prevId];
            int next = _multiset[nextId];
            int neighbor_id = (prev > next) ? prevId : nextId;
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
