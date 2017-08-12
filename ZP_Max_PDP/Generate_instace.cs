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
        // Zmienne
        private List<muliSet> createdMap = new List<muliSet>();

        public Generate_instace()
        {
            InitializeComponent();
        }

        private void ButtonCreateInstance_Click(object sender, EventArgs e)
        {            
            Random randomNumber = new Random();
            if (Convert.ToInt32(NumElements.Value) != 0)
            {
                int distNumber = Convert.ToInt32(NumElements.Value);
                for (int i = 0; i < distNumber; i++)
                {
                    int drawValue = randomNumber.Next(
                        Convert.ToInt32(NumRangeStart.Value), 
                        Convert.ToInt32(NumRangeEnd.Value));
                    createdMap.Add(new muliSet() { elementOfmultiSet = drawValue });  
                }
                DrawGrid.DataSource = createdMap;
                ButtonCreateInstance.Enabled = false;
            }
            else
            {
                MessageBox.Show("Zbiór nie może mieć 0 elementów " + "\n");
            }
        }
   

        // Helper - klasa z multizbiorem

        public class muliSet
        {
            public int elementOfmultiSet { get; set; }

            public muliSet()
            {
                this.elementOfmultiSet = elementOfmultiSet;
            }

            public muliSet(int value)
            {
                this.elementOfmultiSet = value;
            }
        }

       
    }
}
