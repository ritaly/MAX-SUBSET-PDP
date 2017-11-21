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
    public partial class Algo2 : MetroFramework.Controls.MetroUserControl
    {
        private List<multiSet> instanceMultiset;
        private List<int> bestSolutionIds;
        private List<int> _multiset;

        public Algo2(List<multiSet> instanceMultiset, List<int> bestSolutionIds)
        {
            this.instanceMultiset = instanceMultiset;
            this.bestSolutionIds = bestSolutionIds;
            InitializeComponent();
        }

        private void Algo2_Load(object sender, EventArgs e)
        {
            _multiset = new List<int>(); // przechowuje kopię multizbioru jako listę intów,  anie obiektów
            foreach (multiSet o in loadedMultiset)
            {
                _multiset.Add(item: o.elementOfmultiSet);
            }

            solutionGrid.DataSource = instanceMultiset;
            bestIds.Text = String.Join(" ", bestSolutionIds);
        }
    }
}
