using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZP_Max_PDP
{
    public partial class Algo2 : MetroFramework.Controls.MetroUserControl
    {
        private List<multiSet> instanceMultiset;
        private List<multiSet> finalSolution;
        private List<int> bestSolutionIds;
        private List<int> initialSolutionIds;
        private List<int> _multiset;

        public Algo2(List<multiSet> instanceMultiset, List<int> preSolutionIds)
        {
            this.instanceMultiset = instanceMultiset;
            this.initialSolutionIds = preSolutionIds;
            InitializeComponent();
        }

        private void Algo2_Load(object sender, EventArgs e)
        {
            _multiset = new List<int>(); // copy multiset as int list
            foreach (multiSet o in instanceMultiset)
            {
                _multiset.Add(item: o.elementOfmultiSet);
            }

            sizeElements.Text = _multiset.Count().ToString();
            bestHillClimbing.Text = initialSolutionIds.Count.ToString();
            progressBar.Minimum = 0;
        }

        List<int[]> tabuList; // [id, cadence]
        List<int> currentBestIds; // per iteration
        List<int> restartBestIds; // best in restart

        private void computeButton_Click(object sender, EventArgs e)
        {
            finalSolution = new List<multiSet>();
            progressBar.Visible = true;
            progressBar.Value = progressBar.Minimum;
            progressBar.Maximum = Convert.ToInt32(rangeRestart.Value) * Convert.ToInt32(iterPerRestartRange.Value);
            double partialTime = 0.0; // for restart
            System.Diagnostics.Stopwatch globalTimer = System.Diagnostics.Stopwatch.StartNew(); 

            int restarts = Convert.ToInt32(rangeRestart.Value);
            int iterPerRestart = Convert.ToInt32(iterPerRestartRange.Value); 
            double sizeTabuAsProc = (double)Convert.ToInt32(sizeTabu.Value) / 100;
            int sizeOfTabu;
            int cadenceOfTabu = Convert.ToInt32(cadenceTabu.Value);
            
            int axisY = YChart(_multiset.Count());
            tabTabuChart.Series.Clear();
            tabTabuChart.Invalidate();

            var ChartSolution = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "M",
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            this.tabTabuChart.Series.Add(ChartSolution);
            tabTabuChart.ChartAreas[0].AxisX.Maximum = (restarts * iterPerRestart);
            tabTabuChart.ChartAreas[0].AxisY.Maximum = axisY;
            tabTabuChart.ChartAreas[0].AxisX.Interval = iterPerRestart;
            tabTabuChart.ChartAreas[0].AxisY.Title = "Liczba elementów rozwiązania P (max M)";
            tabTabuChart.ChartAreas[0].AxisX.Title = "Liczba iteracji";

            tabSolChart.Series.Clear();
            tabSolChart.Invalidate();
            int one3 = iterPerRestart / 3;
            var ChartSolution2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "M2",
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            this.tabSolChart.Series.Add(ChartSolution2);
            tabSolChart.ChartAreas[0].AxisX.Maximum = (restarts * iterPerRestart);
            tabSolChart.ChartAreas[0].AxisY.Maximum = axisY;
            tabSolChart.ChartAreas[0].AxisX.Interval = iterPerRestart;
            tabSolChart.ChartAreas[0].AxisY.Title = "Liczba elementów rozwiązania P (max M)";
            tabSolChart.ChartAreas[0].AxisX.Title = "Liczba iteracji";

            tabuList = new List<int[]>(); //[id, cadence]
            bestSolutionIds = new List<int>(initialSolutionIds);
            restartBestIds = new List<int>(initialSolutionIds);
            while (restarts != 0)
            {
                if (restarts % 3 == 0) //clear initial solution
                {
                    GenerateNewInitialSolution();
                    restartBestIds = new List<int>(initialSolutionIds);
                }
                if (restarts % 5 == 0) // clear tabu
                {
                    ClearTabu();
                }

                currentBestIds = new List<int>(restartBestIds);
                for (int i = 0; i < iterPerRestart; i++)
                {
                    if (i % 10 == 0)
                    {
                        AddElementToSolution();

                    }

                    sizeOfTabu = (int)Math.Ceiling((double)currentBestIds.Count * sizeTabuAsProc);
                    System.Diagnostics.Stopwatch iterTimer = System.Diagnostics.Stopwatch.StartNew();
                    tabuList.RemoveAll(match: t => t[1] == 0); //tabu update
                    tabuList.ForEach(f => f[1] -= 1);
                    if (tabuList.Count > sizeOfTabu)
                    {
                        tabuList.RemoveAt(0);
                    }
                    List<int> valuesOnTabu = new List<int>(tabuList.Select(s => s[0]).ToList()); //copy ids to int list
                    int idToMove = RandElementToMove(valuesOnTabu);
                    int idOnMultiset = currentBestIds[idToMove]; //actual id

                    int[] tabuElem = new int[2] { idOnMultiset, cadenceOfTabu };
                    tabuList.Add(tabuElem);
                    //algorithm: find neibours, move, update structure
                    List<int> candidatesList = FindNeighbors(idToMove); 
                    MakeMove(idOnMultiset, idToMove, candidatesList);

                    if (currentBestIds.Count > restartBestIds.Count)
                    {
                        restartBestIds = new List<int>(currentBestIds);
                    }
                    ChartSolution.Points.AddY(currentBestIds.Count);
                    ChartSolution2.Points.AddY(currentBestIds.Count);
                    tabTabuChart.Update();
                    tabSolChart.Update();

                    progressBar.Value += 1;
                    progressBar.Update();
                    iterTimer.Stop();
                    partialTime += iterTimer.ElapsedMilliseconds;
                    timerLabel.Text = (partialTime * 0.001).ToString();
                    timerLabel.Update();
                }
                if (restartBestIds.Count > bestSolutionIds.Count)
                {
                    bestSolutionIds = new List<int>(restartBestIds);
                }
                restarts--;
            }

            sizeSolutionTabu.Text = bestSolutionIds.Count.ToString();
            sizeSolutionTabu.Update();
            globalTimer.Stop();
            progressBar.Value += 1;
            
            timerLabel.Text = (globalTimer.ElapsedMilliseconds * 0.001).ToString();
            MessageBox.Show("Zakończono obliczenia");
            //MessageBox.Show("Koniec: " + String.Join(",", bestSolutionIds.Select(x => _multiset[x])));


            foreach (int o in bestSolutionIds)
            {
                finalSolution.Add(new multiSet { elementOfmultiSet = _multiset[o] });
            }
            finalSolution = finalSolution.OrderBy(o => o.elementOfmultiSet).ToList(); //sort output
            solutionGrid.Refresh();
            solutionGrid.DataSource = finalSolution;
        }
        // ------------- MAKE MOVE TABU -------------
        public void MakeMove(int idx, int idc, List<int> candidats)
        {
            bool is_valid = false;

            // ------------- ADD ELEMENT -------------
            foreach (int candidat in candidats)
            {
                currentBestIds.Add(candidat); //add candidat

                // ------------- generate multiset from ids -------------
                List<int> currentMultiset = new List<int>();
                foreach (int i in currentBestIds)
                {
                    currentMultiset.Add(_multiset[i]);
                }
                for (int i = 0; i < currentBestIds.Count; i++)
                {
                    int index = currentBestIds[i];
                    foreach (int item in currentBestIds.Skip(i + 1).ToList())
                    {
                        currentMultiset.Add(Math.Abs(_multiset[index] - _multiset[item]));
                    }
                }
                is_valid = CanBeSolution(currentMultiset);
                
                if (is_valid == false) //invalid remove
                {
                    currentBestIds.RemoveAt(currentBestIds.Count - 1);
                }
                else
                {
                    break;
                }
            }
            // ------------- SWAP ELEMENT -------------

            if (!is_valid)
            {
                foreach (int candidat in candidats)
                {
                    currentBestIds[idc] = candidat; // swap idx <=> candidat
                    // ------------- generate multiset from ids -------------
                    List<int> currentMultiset = new List<int>();
                    foreach (int i in currentBestIds)
                    {
                        currentMultiset.Add(_multiset[i]);
                    }

                    for (int i = 0; i < currentBestIds.Count; i++)
                    {
                        int index = currentBestIds[i];
                        foreach (int item in currentBestIds.Skip(i + 1).ToList())
                        {
                            currentMultiset.Add(Math.Abs(_multiset[index] - _multiset[item]));
                        }
                    }
                    is_valid = CanBeSolution(currentMultiset);
                    if (!is_valid) //recover last structure
                    {
                        currentBestIds[idc] = idx; // swap idx <=> candidat
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // ------------- REMOVE ELEMENT -------------
            if (!is_valid)
            {
                currentBestIds.RemoveAll(i => i == idx);  //--- structure update --

            }
        }

        public bool CanBeSolution(List<int> currentMultiset)
        {
            //currentMultiset.All(_multiset.Contains);
            IEnumerable<int> both = Compare2Lists(currentMultiset, _multiset);
            bool subsetOf = (currentMultiset.Count() == both.Count()) ? true : false;
            return subsetOf;
        }
        public static IEnumerable<T> Compare2Lists<T>(IEnumerable<T> source, IEnumerable<T> target)
        {
            List<T> list = target.ToList();
            foreach (T item in source)
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                    yield return item;
                }
            }
        }

        private void AddElementToSolution()
        {
            Random randomValue = new Random();
            int minValue = 0;
            int maxValue = _multiset.Count;
            int aid = randomValue.Next(minValue: minValue, maxValue: maxValue);
            bool valid = false;
            currentBestIds.Add(aid); //add candidat

            // ------------- generate multiset from ids -------------
            List<int> currentMultiset = new List<int>();
            foreach (int i in currentBestIds)
            {
                currentMultiset.Add(_multiset[i]);
            }
            for (int i = 0; i < currentBestIds.Count; i++)
            {
                int index = currentBestIds[i];
                foreach (int item in currentBestIds.Skip(i + 1).ToList())
                {
                    currentMultiset.Add(Math.Abs(_multiset[index] - _multiset[item]));
                }
            }
            valid = CanBeSolution(currentMultiset);
            if (valid == false) //invalid remove
            {
                currentBestIds.RemoveAt(currentBestIds.Count - 1);
            }
            else
            {
                AddElementToSolution();
            }
        }

        private void ClearTabu()
        {
            tabuList = new List<int[]>();
        }

        public int RandElementToMove(List<int> valuesOnTabu)
        {
            Random randomValue = new Random();
            int minValue = 0;
            int maxValue;
            int value;
            bool AllOnTabu = false;
            if (currentBestIds.All(valuesOnTabu.Contains))
            {
                AllOnTabu = true;
            }
            Console.WriteLine(AllOnTabu);
            if (AllOnTabu)
            {
                ClearTabu();
            }
            maxValue = currentBestIds.Count;
            value = randomValue.Next(minValue: minValue, maxValue: maxValue);
            int index = currentBestIds[value];
            if (tabuList.Any(k => k[0] == index)) // is index on tabu list now?
            {
                RandElementToMove(valuesOnTabu);
            }

            return value;
        }
        public List<int> FindNeighbors(int id)
        {
            int prevId = (id == 0) ? id : FindPrev(id);
            int nextId = (id == _multiset.Count() - 1) ? id : FindNex(id);

            int prev2Id = -1;
            if (prevId != 0)
            {
                prev2Id = FindPrev(prevId - 1);
            }
            int next2Id = -1;
            if (nextId != (_multiset.Count() - 1))
            {
                next2Id = FindPrev(nextId + 1);
            }

            List<int> neighborhood = new List<int>();
            neighborhood.Add(prevId);
            neighborhood.Add(nextId);
            if (prev2Id != -1)
            {
                neighborhood.Add(prev2Id);
            }
            if (next2Id != -1)
            {
                neighborhood.Add(next2Id);
            }
            return neighborhood;
        }

        public int FindPrev(int start)
        {
            int i = start;
            while (i > 0)
            {
                if (tabuList.Any(k => k[0] == i) || currentBestIds.Contains(i)) // is index on tabu list or in current solution now?
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
        public int FindNex(int start)
        {
            int i = start;
            while (i < _multiset.Count())
            {
                if (tabuList.Any(k => k[0] == i) || currentBestIds.Contains(i))
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            i = (i != _multiset.Count()) ? i : start;
            return i;
        }

        // ------------- REINITIAL WITH HILLCLIMBING -------------
        public void GenerateNewInitialSolution()
        {
            //return initialSolutionIds! hillclimbing
            int minValue = 0;
            int maxValue = _multiset.Count;
            Random randomValue = new Random();
            int idx = randomValue.Next(minValue: minValue, maxValue: maxValue);
            bool isEnd = false;
            initialSolutionIds = new List<int>();
            isEnd = HillClimbing(idx);
            if (isEnd)
            {
                if (initialSolutionIds.Count() < 1)
                {
                    GenerateNewInitialSolution();
                }
            }
        }

        public bool HillClimbing(int idx)
        {
            initialSolutionIds.Add(idx);
            // ------------- generate multiset from ids -------------
            List<int> currentMultiset = new List<int>();
            foreach (int i in initialSolutionIds)
            {
                currentMultiset.Add(_multiset[i]);
            }

            for (int i = 0; i < initialSolutionIds.Count; i++)
            {
                int index = initialSolutionIds[i];
                foreach (int item in initialSolutionIds.Skip(i + 1).ToList())
                {
                    currentMultiset.Add(Math.Abs(_multiset[index] - _multiset[item]));
                }
            }
            bool is_valid = CanBeSolution(currentMultiset);
            if (!is_valid)
            {
                initialSolutionIds.RemoveAt(initialSolutionIds.Count - 1);
                return true;
            }
            else
            {
                int neighborId = FindNeighbor(idx);
                if (_multiset[neighborId] > _multiset[idx])
                {
                    //new max
                    return HillClimbing(neighborId);
                }
                else
                {
                    return true;
                }
            }
        }
        public int FindNeighbor(int id)
        {
            int prevId = (id == 0) ? id : FindPrevious(id);
            int nextId = (id == _multiset.Count() - 1) ? id : FindNext(id);
            int prev = _multiset[prevId];
            int next = _multiset[nextId];
            int neighbor_id = (prev > next) ? prevId : nextId;
            return neighbor_id;
        }

        public int FindPrevious(int start)
        {
            int i = start;
            while (i > 0)
            {
                if (initialSolutionIds.Contains(i))
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
        public int FindNext(int start)
        {
            int i = start;
            while (i < initialSolutionIds.Count())
            {
                if (initialSolutionIds.Contains(i))
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            i = (i != initialSolutionIds.Count()) ? i : start;
            return i;
        }

        private int YChart(int numElements)
        {
            int isSquare = numElements * 8 + 1;
            isSquare = (int)Math.Sqrt(isSquare);
            int max = (int)(1 + isSquare) / 2;
            return max;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = string.Format("\\final-" + finalSolution.Count.ToString() + "-{0:yyyy-MM-dd-hh-mm-ss-tt}", DateTime.Now);
            string format = ".csv";
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            path = Path.Combine(path, "Instance");
            string filePath = path + name + format;
            using (var file = File.CreateText(filePath))
            {
                foreach (var item in finalSolution)
                {
                    file.WriteLine(item.elementOfmultiSet + ",");
                }
            }
            SaveButton.Text = "✔️ Zapisano";
            SaveButton.Enabled = false;
        }
    }
}
