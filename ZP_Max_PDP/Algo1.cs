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
    {   //HillClimbing
        private List<int> _multiset;
        private List<multiSet> loadedMultiset;
        private List<multiSet> finalSolution;

        public Algo1(List<multiSet> loadedMultiset)
        {
            this.loadedMultiset = loadedMultiset;
            _multiset = new List<int>(); // przechowuje kopię multizbioru jako listę intów,  anie obiektów
            foreach (multiSet o in loadedMultiset)
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
        List<int> bestSolutionIds = new List<int>();
        List<int> currentSolution; //najlepsze w danym restarcie 
        List<int> currentSolutionIds;
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
                currentSolutionIds = new List<int>();
                isDeleted = Enumerable.Repeat(false, _multiset.Count).ToArray();
                int idx = randomValue.Next(minValue: minValue, maxValue: maxValue); // first max value id
                int x = _multiset[idx];
                bool isEnd = false;
                isEnd = FindSolution(x, idx, currentSolution, currentSolutionIds);

                if (isEnd)
                {
                    bestSolution = (currentSolution.Count > bestSolution.Count) ? currentSolution : bestSolution;
                    bestSolutionIds = (currentSolutionIds.Count > bestSolutionIds.Count) ? currentSolutionIds : bestSolutionIds;
                    sizeSolution.Text = bestSolution.Count().ToString();
                    sizeSolution.Update();
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
            solutionGrid.Visible = true;

            finalSolution = new List<multiSet>();
            MessageBox.Show("Ids: " + String.Join(" ", bestSolutionIds));
            foreach (int o in bestSolution)
            {
                finalSolution.Add(new multiSet { elementOfmultiSet = o });
            }
            solutionGrid.DataSource = finalSolution;
        }

        public bool FindSolution(int x, int id, List<int> current, List<int> currentIds)
        {
            int max = x;
            current.Add(x);
            currentIds.Add(id);

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
                currentIds.RemoveAt(currentIds.Count - 1);
                current.RemoveAt(current.Count - 1);
                return true;
            }
            else
            {
                isDeleted[id] = true;
                int neighborId = FindNeighbor(id);
                currentSolution = current;
                currentSolutionIds = currentIds;
                if (_multiset[neighborId] > max)
                {
                    //nowy max
                    x = _multiset[neighborId];
                    return FindSolution(x, neighborId, current, currentIds);
                }
                else
                {
                    //jednak mniejsze lub równe to nie szukamy dalej
                    return true;
                }
            }

        }

        public bool CanBeSolution(List<int> currentMultiset)
        {
            string s = "current: " + String.Join(" ", currentMultiset) + "\n M: " + String.Join(" ", _multiset) + "\n " + (!currentMultiset.Except(_multiset).Any()).ToString();
            //MessageBox.Show(s);
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (!StartForm.Instance.MetroContainer.Controls.ContainsKey("Algo2"))
            {
                Algo2 li = new Algo2(loadedMultiset);
                li.Dock = DockStyle.Fill;
                StartForm.Instance.MetroContainer.Controls.Add(li);
            }
            StartForm.Instance.MetroContainer.Controls["Algo2"].BringToFront();
            StartForm.Instance.ButtonBack.Visible = true;
        }

    }
}
