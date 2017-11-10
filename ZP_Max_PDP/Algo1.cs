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
        private List<multiSet> _multiset;
        

        public Algo1(List<multiSet> fromMultiset)
        {
            _multiset = fromMultiset;
            InitializeComponent();
        }

        private void startClimbing_Click(object sender, EventArgs e) 
        {
           // List<multiSet> currentSolution = new List<multiSet>();
            int minValue = 0;
            int maxValue = _multiset.Count;
            int restarts = Convert.ToInt32(rangeRestart.Value);
            Random randomValue = new Random();
            List<int> bestSolution = new List<int>(); //tu bdzie najlepsze w danym restarcie

            while (restarts!=0)
            {
                List<int> actualSolution = new List<int>();
                List<multiSet> possibleItems = new List<multiSet>(_multiset);
                
                bool[] deleted = Enumerable.Repeat(false, possibleItems.Count).ToArray();
                int id = randomValue.Next(minValue: minValue, maxValue: maxValue); // actual max value id
                int max = possibleItems[id].elementOfmultiSet;
                deleted[id] = true;
                actualSolution.Add(max);

                int prev;
                int next;
                int prev_id = (id == 0) ? -1 : FindPrevious(id - 1, deleted);
                int next_id = (id == deleted.Count()-1) ? -1 : FindNext(id, deleted);
                
                if (prev_id == -1)
                {
                    prev = -1;
                }
                else
                {
                    prev = possibleItems[prev_id].elementOfmultiSet;
                }

                if (next_id == -1)
                {
                    next = -1;
                }
                else
                {
                    next = possibleItems[next_id].elementOfmultiSet;
                }


               
                 //tutaj funkcja  muszę pamiętać, którego sąsiada mam, albo zamiast tego wywołujemy 
                 //funkcję zwracającą wynik jeśli tak to nie muszę mieć  prev czy next
                

                
               /* int prev = possibleItems[id - 1].elementOfmultiSet;
                int next = possibleItems[id + 1].elementOfmultiSet;
                int neighbor_id = (prev > next) ? (id - 1) : (id + 1);
                int neighbor = possibleItems[neighbor_id].elementOfmultiSet; ;

                if (max > neighbor)
                {
                    restarts++;
                    break;
                }
                else
                {
                    actualSolution.Add(neighbor);
                    List<int> actualMultiset = new List<int>(actualSolution);

                    for (int i = 0; i < actualSolution.Count; i++ )
                    {
                        MessageBox.Show("jestem!");
                        foreach (int item in actualSolution.Skip(i + 1).ToList())
                        {
                            actualMultiset.Add(Math.Abs(actualSolution[i] - item));
                        }
                    }

                    
                }*/

                progressBar.Value +=1;
                progressBar.Update();
                
            }
            MessageBox.Show("I'm out");
        }

        public int FindPrevious(int start, bool []deleted)
        {
            int i = start;
            while (i >= 0)
            {
                Console.WriteLine(i);
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
        public int FindNext(int start, bool []deleted)
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
            return i;
        }

        private void Algo1_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = Convert.ToInt32(rangeRestart.Value); 
        }
    }
}
