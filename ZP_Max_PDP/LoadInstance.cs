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

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Wybierz plik CSV z instancją";

            ofd.Filter = "CSV|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = ofd.SafeFileName;
                fullPath.Text = ofd.FileName;

                StreamReader read = new StreamReader(File.OpenRead(ofd.FileName));
                metroTextBox1.Text = read.ReadToEnd();
                read.Dispose();
            }

        }

 
    }
}
