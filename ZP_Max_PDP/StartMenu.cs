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
    public partial class StartMenu : MetroFramework.Controls.MetroUserControl
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (!StartForm.Instance.MetroContainer.Controls.ContainsKey("Generate_instace"))
            {
                Generate_instace gi = new Generate_instace(); //przechodzi do generowana nowej instancji
                gi.Dock = DockStyle.Fill;
                StartForm.Instance.MetroContainer.Controls.Add(gi);
            }
            StartForm.Instance.MetroContainer.Controls["Generate_instace"].BringToFront();
            StartForm.Instance.ButtonBack.Visible = true;
        }

        private void FromFile_Click(object sender, EventArgs e)
        {
            if (!StartForm.Instance.MetroContainer.Controls.ContainsKey("LoadInstance"))
            {
                LoadInstance li = new LoadInstance();
                li.Dock = DockStyle.Fill;
                StartForm.Instance.MetroContainer.Controls.Add(li);
            }
            StartForm.Instance.MetroContainer.Controls["LoadInstance"].BringToFront();
            StartForm.Instance.ButtonBack.Visible = true;
        }

    }
}
