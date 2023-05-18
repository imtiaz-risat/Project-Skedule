using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skedule
{
    public partial class DashboardChildForm : UserControl
    {
        public Form1 parentForm { get; set; }

        public DashboardChildForm()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void DashboardChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
