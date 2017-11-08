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
            Random randomValue = new Random();
            int minValue = 0;
            int maxValue = Convert.ToInt32(_multiset.Count);
            for (int i = 0; i <= rangeRestart.Value; i++)
            {
                int randomStart = randomValue.Next(minValue: minValue, maxValue: maxValue); // actual max value
                int max = randomStart; 
                //compare to neibourhoods

                

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
