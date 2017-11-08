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
    public partial class LoadInstance : MetroFramework.Controls.MetroUserControl
    {
        public LoadInstance()
        {
            InitializeComponent();
        }

        private List<multiSet> instanceMultiset = new List<multiSet>();

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Wybierz plik CSV z instancją";
            ofd.Filter = "CSV |*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = ofd.SafeFileName;
                fullPath.Text = ofd.FileName;

                List<multiSet> readMultiset = File.ReadAllLines(ofd.FileName)
                                           .Select(v => multiSet.FromCsv(v))
                                           .ToList();
                bool withZero = false;

                if ((readMultiset != null) && (readMultiset.Count != 0))
                {
                    firstGrid.DataSource = readMultiset;
                    NextButton.Visible = true;
                    withZero = readMultiset.Any(x => x.elementOfmultiSet == 0);
                }
                else
                {
                    MessageBox.Show("Multizbiór pusty.\nWybierz inny plik źródłowy");
                }

                if (withZero)
                {
                    infoLabel.Visible = true;
                    instanceMultiset.AddRange(readMultiset);
                    instanceMultiset.RemoveAll(d => d.elementOfmultiSet == 0);
                    secondGrid.DataSource = instanceMultiset;
                }
                else
                {
                    instanceMultiset.AddRange(readMultiset);
                }
               
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (!StartForm.Instance.MetroContainer.Controls.ContainsKey("Algo1"))
            {
                Algo1 li = new Algo1(instanceMultiset);
                li.Dock = DockStyle.Fill;
                StartForm.Instance.MetroContainer.Controls.Add(li);
            }
            StartForm.Instance.MetroContainer.Controls["Algo1"].BringToFront();
            StartForm.Instance.ButtonBack.Visible = true;
        }

 
    }
}
