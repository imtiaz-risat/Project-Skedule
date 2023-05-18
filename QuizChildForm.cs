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
    public partial class QuizChildForm : UserControl
    {
        public Form1 parentForm { get; set; }
        public bool TopLevel { get; internal set; }

        public QuizChildForm()
        {
            InitializeComponent();
        }

        private void buttonEditClass_Click(object sender, EventArgs e)
        {

        }

        private void QuizChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
