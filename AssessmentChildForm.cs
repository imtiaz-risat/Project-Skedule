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
    public partial class AssessmentChildForm : UserControl
    {
        public Form1 parentForm { get; set; }
        public bool TopLevel { get; internal set; }

        public AssessmentChildForm()
        {
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void AssessmentChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
