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
    public partial class Generate_instace : MetroFramework.Controls.MetroUserControl 
    {
        public Generate_instace()
        {
            InitializeComponent();
        }

        private void ButtonCreateInstance_Click(object sender, EventArgs e)
        {
            int distNumber = Convert.ToInt32(NumElements.Value);
            Random random_number = new Random();
            if (distNumber != 0)
            {

            }
            else
            {
                MessageBox.Show("Zbiór nie może mieć 0 elementów " + "\n");
            }
        }
   

       
    }
}
