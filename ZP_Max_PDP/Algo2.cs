using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.bestSolutionIds = preSolutionIds;
            InitializeComponent();
        }

        private void Algo2_Load(object sender, EventArgs e)
        {
            _multiset = new List<int>(); // przechowuje kopię multizbioru id jako listę intów,  anie obiektów
            foreach (multiSet o in instanceMultiset)
            {
                _multiset.Add(item: o.elementOfmultiSet);
            }
            
            sizeElements.Text = _multiset.Count().ToString();
            bestHillClimbing.Text = initialSolutionIds.Count.ToString();
            progressBar.Minimum = 0;
        }

        List<int[]> tabuList; //lista tabu 
        List<int> currentBestIds;
        List<int> restartBestIds; //najlepszy wynik w danym restrcie

        private void computeButton_Click_1(object sender, EventArgs e)
        {
            finalSolution = new List<multiSet>();
            progressBar.Visible = true;
            progressBar.Value = progressBar.Minimum;
            progressBar.Maximum = Convert.ToInt32(rangeRestart.Value) * Convert.ToInt32(iterPerRestartRange.Value);
            double partialTime = 0.0; // zegar dla poszczególnych restartów
            System.Diagnostics.Stopwatch globalTimer = System.Diagnostics.Stopwatch.StartNew(); //start globalnego zegara

            int restarts = Convert.ToInt32(rangeRestart.Value);
            int iterPerRestart = Convert.ToInt32(iterPerRestartRange.Value); //liczba iteracji w danym restarcie
            int sizeTabuAsProc = Convert.ToInt32(sizeTabu.Value)/100;
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
            tabTabuChart.ChartAreas[0].AxisY.Maximum = axisY+1;
            tabTabuChart.ChartAreas[0].AxisX.Interval = iterPerRestart;
            tabTabuChart.ChartAreas[0].AxisX.Title = "Liczba elementów rozwiązania P (max M)";
            tabTabuChart.ChartAreas[0].AxisY.Title = "Liczba iteracji";

            tabSolChart.Series.Clear();
            tabSolChart.Invalidate();
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
            tabSolChart.ChartAreas[0].AxisY.Maximum = axisY+1;
            tabSolChart.ChartAreas[0].AxisX.Interval = iterPerRestart;
            tabSolChart.ChartAreas[0].AxisX.Title = "Liczba elementów rozwiązania P (max M)";
            tabSolChart.ChartAreas[0].AxisY.Title = "Liczba iteracji";

            while (restarts!=0) {
               if (restarts % 3 == 0)
                {
                    GenerateNewInitialSolution();
                }
               restartBestIds = new List<int>(initialSolutionIds);
               currentBestIds = new List<int>(restartBestIds);

                for (int i=0; i < iterPerRestart; i++)
                {
                    sizeOfTabu = (int)Math.Floor((double)currentBestIds.Count * sizeTabuAsProc);
                    tabuList = new List<int[]>(sizeOfTabu); //przechuwuje listę int odp indeksom w multisecie
                    System.Diagnostics.Stopwatch iterTimer = System.Diagnostics.Stopwatch.StartNew();
                    //trzeba uaktualniec tabu inaczej moze nie być miejsca by dodać do tabu
                    tabuList.RemoveAll(match: r => r[1] == 0);
                    tabuList.ForEach(f => f[1] -= 1);
                    //losuj id do wykonnia ruchu
                    int idOnCurrent = RandElementToMove();
                    int idOnMultiset = currentBestIds[idOnCurrent]; //actualne id

                    int[] tabuElem = new int[2] { idOnMultiset, cadenceOfTabu };
                    tabuList.Add(tabuElem);
                    //znajdz sasiadow
                    List<int> candidatesList = FindNeighbors(idOnMultiset);
                    //wykonaj ruch
                    MakeMove(idOnMultiset, idOnCurrent, candidatesList);
                    ChartSolution.Points.AddY(currentBestIds.Count());
                    ChartSolution2.Points.AddY(currentBestIds.Count());
                    tabTabuChart.Update();
                    tabSolChart.Update();
                    
                    progressBar.Value += 1;
                    progressBar.Update();
                    iterTimer.Stop();
                    partialTime += iterTimer.ElapsedMilliseconds;
                    timerLabel.Text = (partialTime * 0.001).ToString();
                    timerLabel.Update();

                }
                bestSolutionIds = (restartBestIds.Count > bestSolutionIds.Count) ? currentBestIds : bestSolutionIds;
                restarts--;
            }
            globalTimer.Stop();
            progressBar.Value += 1;
            timerLabel.Text = (globalTimer.ElapsedMilliseconds * 0.001).ToString();
            MessageBox.Show("koniec : " + String.Join(",", bestSolutionIds.Select(x => _multiset[x])));

            
            foreach (int o in bestSolutionIds)
            {
                finalSolution.Add(new multiSet { elementOfmultiSet = _multiset[o] });
            }
            finalSolution = finalSolution.OrderBy(o => o.elementOfmultiSet).ToList(); //Sort Output
            solutionGrid.Refresh();
            solutionGrid.DataSource = finalSolution;
            sizeSolutionTabu.Text = bestSolutionIds.Count.ToString();

        }

        // ------------- MAKE MOVE TABU -------------
        public void MakeMove(int idx, int idc, List<int> candidats)
        {
            bool is_valid = false; //switch move

            // ------------- ADD ELEMENT -------------
            foreach (int candidat in candidats)
            {
                currentBestIds.Add(candidat); //dla kazdego kandydata - dodaj 
                // ------------- generate multiset from ids -------------
                List<int> currentMultiset = new List<int>(); //wygeneruj multiset 
                foreach (int i in currentBestIds)
                {
                    currentMultiset.Add(_multiset[i]);
                }
                //string s = "kandydat : " + _multiset[candidat].ToString() + "\n";

                for (int i = 0; i < currentBestIds.Count; i++)
                {
                    int index = currentBestIds[i];
                    foreach (int item in currentBestIds.Skip(i + 1).ToList())
                    {
                        currentMultiset.Add(Math.Abs( _multiset[index] - _multiset[item]));
                    }
                }
                is_valid = CanBeSolution(currentMultiset);
               // s += "\n koniec : " + String.Join(",", currentBestIds.Select(x => _multiset[x])) + "\n";
               // s += "currentBestIds: " + String.Join(" ", currentBestIds).ToString() + "\n Multi: "+ String.Join("-", currentMultiset) + "\n M:" +  String.Join(" ", _multiset) + "\n" + is_valid.ToString();
               // MessageBox.Show(s);
                if (!is_valid) //jak nie pasuje to usun ostatnio dodany
                {
                    currentBestIds.RemoveAt(currentBestIds.Count - 1);
                }
                else
                {
                    //--- structure update ---
                    restartBestIds = (currentBestIds.Count > restartBestIds.Count) ? currentBestIds : restartBestIds;
                    break;
                }
                
            }
            // ------------- SWAP ELEMENT -------------
            if (!is_valid)
            {
                foreach (int candidat in candidats)
                {
                    currentBestIds[idc] = candidat; // swap idx <=> candidat
                    List<int> currentMultiset = new List<int>(); //wygeneruj multiset 
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
                    if (!is_valid) //jak nie pasuje to wroc
                    {
                        currentBestIds[idc] = idx; // swap idx <=> candidat
                    }
                    else
                    {
                        restartBestIds = (currentBestIds.Count > restartBestIds.Count) ? currentBestIds : restartBestIds;
                        break;
                    }
                }
            }

            // ------------- REMOVE ELEMENT -------------
            if (!is_valid) //jak nie da się dodac to usun
            {
                currentBestIds.RemoveAll(i => i == idx );  //--- structure update --
                
            }
            // string t ="current: " + String.Join(" ", currentBestIds) +"\n bestids: " + String.Join(" ", restartBestIds) ;
            //string t = "koniec : " + String.Join(",", currentBestIds.Select(x => _multiset[x]));
            //t += "\n valid?" + is_valid.ToString();
            //MessageBox.Show(t);
        }

        public bool CanBeSolution(List<int> currentMultiset)
        {
            return currentMultiset.All(_multiset.Contains);
        }

        Random randomValue = new Random();
        public int RandElementToMove()
        {
            int minValue = 0;
            int maxValue = currentBestIds.Count;
            int value = randomValue.Next(minValue: minValue, maxValue: maxValue);
            int index = currentBestIds[value];
            if (tabuList.Any(k => k[0] == index))// to id czy na liście tabu
            {

                 RandElementToMove();
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
                prev2Id = FindPrev(prevId-1);
            }
            int next2Id = -1;
            if (nextId != (_multiset.Count() - 1) )
            {
                next2Id = FindPrev(nextId+1);
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
                if (tabuList.Any(k => k[0] == i) || currentBestIds.Contains(i)) // czy usunięte to teraz czy na liście tabu lub w rozwiązaniu
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
            //return initialSolutionIds! wspinaczka
            int minValue = 0;
            int maxValue = _multiset.Count;
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
            List<int> currentMultiset = new List<int>(); //wygeneruj multiset 
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
                    //nowy max
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
    }
}
