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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Code to open the LogincChildForm inside the panel
            LoginChildForm loginchildForm = new LoginChildForm();
            loginchildForm.TopLevel = false;
            loginchildForm.Parent = childFormPanel; // childFormPanel is the name of Panel control
            loginchildForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(loginchildForm);
            loginchildForm.Show();
        }

    }
}
