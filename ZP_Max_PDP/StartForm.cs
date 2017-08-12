using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZP_Max_PDP
{
    public partial class StartForm : MetroFramework.Forms.MetroForm
    {
        static StartForm _instance;
        public static StartForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StartForm();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return metroPanel1; }
            set { metroPanel1 = value; }
        }

        public MetroFramework.Controls.MetroLink ButtonBack
        {
            get { return LinkBack;  }
            set { LinkBack = value;  }
        }

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            LinkBack.Visible = false;
            _instance = this;
            StartMenu sm = new StartMenu();
            sm.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(sm);
        }

        private void backLink_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls["StartMenu"].BringToFront();
            LinkBack.Visible = false;
        }

    }
}
