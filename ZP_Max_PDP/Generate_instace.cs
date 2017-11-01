﻿using System;
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
        // Zmienne
        private List<multiSet> createdMap = new List<multiSet>();
        private List<multiSet> createdSolution = new List<multiSet>();
        private List<multiSet> createdMultiset = new List<multiSet>();

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
                    int drawValue = randomNumber.Next(minValue: minValue, maxValue: maxValue );
                    createdMap.Add(new multiSet() { elementOfmultiSet = drawValue });
                }
                DrawGrid.DataSource = createdMap; //wypełnianie tabeli
                addDeleteButton(DrawGrid); //delete button
                ButtonCreateInstance.Enabled = false;
                ButtonCreateMultiset.Enabled = true;
                EditDescription.Visible = true;
            }
            else
            {
                MessageBox.Show("Zbiór nie może mieć 0 elementów " + "\n");
            }
        }

        private void ButtonCreateMultiset_Click(object sender, EventArgs e)
        {
            // rozwazanie
            int sum = 0;
            createdSolution.Add(new multiSet() { elementOfmultiSet = 0 }); //pierwszy pkt to 0
            for (int i = 0; i < createdMap.Count; i++)
            {
                sum = sum + createdMap[i].elementOfmultiSet;
                createdSolution.Add(new multiSet() { elementOfmultiSet = sum });
            }
            SolutionGrid.DataSource = createdSolution;
            ButtonCreateMultiset.Enabled = false;

            //generowanie multizbioru

            createdMultiset.AddRange(createdMap);
            for (int i = 0; i < createdMap.Count; i++)
            {
                sum = createdMap[i].elementOfmultiSet;
                foreach (multiSet item in createdMap.Skip(i+1) )
                {
                    sum += item.elementOfmultiSet;
                    createdMultiset.Add(item: new multiSet() { elementOfmultiSet = sum });
                }
            }
            //dodac elementu multizbioru z poziomu interface'u
            MultisetGrid.DataSource = createdMultiset;
            addDeleteButton(MultisetGrid);
            MistakesLabel.Visible = true;
            NumMistakes.Visible = true;
            SaveButton.Visible = true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = string.Format("\\instance-" + createdMap.Count.ToString() + "-{0:yyyy-MM-dd-hh-mm-ss-tt}", DateTime.Now);
            string format = ".csv";
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            path = Path.Combine(path, "Instance");
            string filePath = path + name + format;
            using (var file = File.CreateText(filePath))
            {
                foreach( var item in createdMultiset)
                {
                    file.WriteLine(item.elementOfmultiSet);
                }
            }
            SaveButton.Enabled = false;
        }

        // Helpers

        public class multiSet
        {
            public int elementOfmultiSet { get; set; }

            public multiSet()
            {
                this.elementOfmultiSet = elementOfmultiSet;
            }

            public multiSet(int value)
            {
                this.elementOfmultiSet = value;
            }
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

        private void DrawGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            createdMap.RemoveAt(e.RowIndex);
            DrawGrid.DataSource = createdMap.ToList();
        }

        private void addMapButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(addMapIndex.Value);
            int value = Convert.ToInt32(addMapValue.Value);

            if (index >= createdMap.Count)
            {
                MessageBox.Show("Index nie może być większy niż max index." + "\n" + "Aby dodać element na końcu zbioru wpisz index: -1 " );
            }
            else if (index == -1)
            {
                createdMap.Add(new multiSet() { elementOfmultiSet = value });
                DrawGrid.DataSource = createdMap.ToList();
            }
            else
            {
                createdMap.Insert(index, new multiSet() { elementOfmultiSet = value });
                DrawGrid.DataSource = createdMap.ToList();
            }
        }

        private void MultisetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            createdMultiset.RemoveAt(e.RowIndex);
            MultisetGrid.DataSource = createdMultiset.ToList();
        }

        private void addMultiButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(addMultiIndex.Value);
            int value = Convert.ToInt32(addMultiValue.Value);

            if (index >= createdMultiset.Count)
            {
                MessageBox.Show("Index nie może być większy niż max index." + "\n" + "Aby dodać element na końcu zbioru wpisz index: -1 ");
            }
            else if (index == -1)
            {
                createdMultiset.Add(new multiSet() { elementOfmultiSet = value });
                MultisetGrid.DataSource = createdMultiset.ToList();
            }
            else
            {
                createdMultiset.Insert(index, new multiSet() { elementOfmultiSet = value });
                MultisetGrid.DataSource = createdMultiset.ToList();
            }
        }
    }
}
