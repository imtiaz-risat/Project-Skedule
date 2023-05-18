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
        private LoginChildForm loginForm;
        private DashboardChildForm dashboardForm;

        public Form1()
        {
            InitializeComponent();
            this.Load += MainForm_Load;

            // Instantiate the child forms
            loginForm = new LoginChildForm();
            dashboardForm = new DashboardChildForm();

            // Set the parent form for the child forms
            loginForm.parentForm = this;
            dashboardForm.parentForm = this;
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            // Code to open the LogincChildForm inside the panel
            ShowLoginForm();
        }

        public void ShowLoginForm()
        {
            // Hide the dashboard form
            dashboardForm.Hide();

            // Show the login form inside the panel
            loginForm.TopLevel = false;
            loginForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(loginForm);
            loginForm.Show();
        }


        public void ShowDashboardForm()
        {
            // Hide the login form
            loginForm.Hide();

            // Show the dashboard form inside the panel
            dashboardForm.TopLevel = false;
            dashboardForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }


    }
}
