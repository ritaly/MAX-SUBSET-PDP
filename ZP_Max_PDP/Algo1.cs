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
            for (int i = 0; i <= rangeRestart.Value; i++)
            {
                Random randomValue = new Random();

                progressBar.Value = i;
                progressBar.Update();
            }
        }

        private void Algo1_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = Convert.ToInt32(rangeRestart.Value); 
        }
    }
}
