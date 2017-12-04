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

namespace ZP_Max_PDP
{
    public partial class Generate_instace : MetroFramework.Controls.MetroUserControl
    {
        private BindingList<multiSet> createdMap = new BindingList<multiSet>();
        private List<multiSet> createdSolution = new List<multiSet>();
        private List<multiSet> createdMultiset = new List<multiSet>();
        private BindingList<multiSet> gridMultiset; //temp created Solution

        public Generate_instace()
        {
            InitializeComponent();
        }

        private void ButtonCreateInstance_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int minValue = Convert.ToInt32(NumRangeStart.Value);
            int maxValue = Convert.ToInt32(NumRangeEnd.Value);

            if (Convert.ToInt32(NumElements.Value) != 0)
            {
                for (int i = 0; i < Convert.ToInt32(NumElements.Value); i++)
                {
                    int drawValue = randomNumber.Next(minValue: minValue, maxValue: maxValue);
                    createdMap.Add(new multiSet() { elementOfmultiSet = drawValue });
                }
                DrawGrid.DataSource = createdMap; //fill table
                addDeleteButton(DrawGrid); //add delete buttons 
                ButtonCreateInstance.Enabled = false;
                ButtonCreateMultiset.Enabled = true;
                EditDescription.Visible = true;

                AddMapLabel.Visible = true;
                addMapIndex.Visible = true;
                addMapValue.Visible = true;
                addmapid.Visible = true;
                addmapv.Visible = true;
                addMapButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Zbiór nie może mieć 0 elementów " + "\n");
            }
        }

        private void ButtonCreateMultiset_Click(object sender, EventArgs e)
        {

            int sum = 0;
            // ------------- GENERATE SOLUTION -------------
            for (int i = 0; i < createdMap.Count; i++)
            {
                sum = sum + createdMap[i].elementOfmultiSet;
                createdSolution.Add(new multiSet() { elementOfmultiSet = sum });
            }
            SolutionGrid.DataSource = createdSolution;
            ButtonCreateMultiset.Enabled = false;

            //create multiset / generate all distances
            createdMultiset.AddRange(createdMap); // copy
            for (int i = 0; i < createdMap.Count; i++)
            {
                sum = createdMap[i].elementOfmultiSet;
                foreach (multiSet item in createdMap.Skip(i + 1))
                {
                    sum += item.elementOfmultiSet;
                    createdMultiset.Add(item: new multiSet() { elementOfmultiSet = sum });
                }
            }
            gridMultiset = new BindingList<multiSet>(createdMultiset);
            MultisetGrid.DataSource = gridMultiset;
            addDeleteButton(MultisetGrid);

            // UI update
            AddMultiLabel.Visible = true;
            addMultiIndex.Visible = true;
            addMultiValue.Visible = true;
            addmultiid.Visible = true;
            addmultiv.Visible = true;
            addMultiButton.Visible = true;

            MistakesLabel.Visible = true;
            mistakesButton.Visible = true;
            NumMistakes.Visible = true;
            SaveButton.Visible = true;
            NextButton.Visible = true;
        }
        
        private void addDeleteButton(MetroFramework.Controls.MetroGrid Grid)
        {
            Grid.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.delete,
                Name = "btn",
                HeaderText = "delete"
            });
        }
        // ------------- DELETE FROM GRID -------------
        private void DrawGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                createdMap.RemoveAt(e.RowIndex);
                DrawGrid.Refresh();
            }
        }

        private void addMapButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(addMapIndex.Value);
            int value = Convert.ToInt32(addMapValue.Value);

            if (index >= createdMap.Count)
            {
                MessageBox.Show("Index nie może być większy niż max index: " + (createdMap.Count-1).ToString() + ".\n" + "Aby dodać element na końcu zbioru wpisz index: -1 ");
            }
            else if (index == -1)
            {
                createdMap.Add(new multiSet() { elementOfmultiSet = value });
                DrawGrid.Refresh();
            }
            else
            {
                createdMap.Insert(index, new multiSet() { elementOfmultiSet = value });
                DrawGrid.Refresh();
            }
        }
        // ------------- DELETE FROM GRID -------------
        private void MultisetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                gridMultiset.RemoveAt(e.RowIndex);
                MultisetGrid.Refresh();
            }
        }

        private void addMultiButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(addMultiIndex.Value);
            int value = Convert.ToInt32(addMultiValue.Value);

            if (index >= gridMultiset.Count)
            {
                MessageBox.Show("Index nie może być większy niż max index: " + (gridMultiset.Count - 1).ToString() + ".\n" + "Aby dodać element na końcu zbioru wpisz index: -1 ");
            }
            else if (index == -1)
            {
                gridMultiset.Add(new multiSet() { elementOfmultiSet = value });
                MultisetGrid.Refresh();
            }
            else
            {
                gridMultiset.Insert(index, new multiSet() { elementOfmultiSet = value });
                MultisetGrid.Refresh();
            }
        }

        private void MistakesButton_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int minValue = 1;
            int maxValue = 100;
            int mistakes = Convert.ToInt32(NumMistakes.Value);

            if (mistakes == 0)
            {
                MessageBox.Show("Nie można wstawić 0 błędów " + "\n");
            }
            if (mistakes > gridMultiset.Count)
            {
                MessageBox.Show("Nie można wstawić więcej błędów niż liczba elementów: " + gridMultiset.Count.ToString() + "\n");
            }
            else
            {
                for (int i = 0; i < mistakes; i++)
                {
                    int index = randomNumber.Next(0, gridMultiset.Count);
                    int value = randomNumber.Next(minValue: minValue, maxValue: maxValue);
                    gridMultiset[index] = new multiSet() { elementOfmultiSet = value };
                }
                MultisetGrid.Refresh();
            }
        }

        // ------------- SAVE TO FILE -------------
        private void SaveButton_Click(object sender, EventArgs e)
        {
            createdMultiset = gridMultiset.ToList();
            string name = string.Format("\\instance-" + createdMap.Count.ToString() + "-{0:yyyy-MM-dd-hh-mm-ss-tt}", DateTime.Now);
            string format = ".csv";
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            path = Path.Combine(path, "Instance");
            string filePath = path + name + format;
            createdMultiset = createdMultiset.OrderBy(a => Guid.NewGuid()).ToList(); //desort
            using (var file = File.CreateText(filePath))
            {
                foreach (var item in createdMultiset)
                {
                    file.WriteLine(item.elementOfmultiSet + ",");
                }
            }
            SaveButton.Text = "✔️ Zapisano";
            SaveButton.Enabled = false;
        }

        // ------------- GO TO ALGORITHM -------------
        private void NextButton_Click(object sender, EventArgs e)
        {
            createdMultiset = gridMultiset.ToList(); 
            if (!StartForm.Instance.MetroContainer.Controls.ContainsKey("Algo1"))
            {
                Algo1 li = new Algo1(createdMultiset);
                li.Dock = DockStyle.Fill;
                StartForm.Instance.MetroContainer.Controls.Add(li);
            }
            StartForm.Instance.MetroContainer.Controls["Algo1"].BringToFront();
            StartForm.Instance.ButtonBack.Visible = true;
        }
    }
}