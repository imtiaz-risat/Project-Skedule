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
        private RoutineChildForm routineForm;
        private QuizChildForm quizForm;
        private AnnouncementChildForm annoucementForm;
        private AssessmentChildForm assessmentForm;

        public Form1()
        {
            InitializeComponent();
            this.Load += MainForm_Load;

            // Instantiate the child forms
            loginForm = new LoginChildForm();
            dashboardForm = new DashboardChildForm();
            routineForm = new RoutineChildForm();
            quizForm = new QuizChildForm();
            annoucementForm = new AnnouncementChildForm();
            assessmentForm = new AssessmentChildForm();

            // Set the parent form for the child forms
            loginForm.parentForm = this;
            dashboardForm.parentForm = this;
            routineForm.parentForm = this;
            quizForm.parentForm = this;
            annoucementForm.parentForm = this;
            assessmentForm.parentForm = this;
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
            routineForm.Hide();
            quizForm.Hide();
            annoucementForm.Hide();
            assessmentForm.Hide();

            // Show the login form inside the panel
            loginForm.TopLevel = false;
            loginForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(loginForm);
            loginForm.Show();
        }


        public void ShowDashboardForm()
        {
            // Hide the other forms
            loginForm.Hide();
            routineForm.Hide();
            quizForm.Hide();
            annoucementForm.Hide();
            assessmentForm.Hide();

            // Show the dashboard form inside the panel
            dashboardForm.TopLevel = false;
            dashboardForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }

        public void ShowRoutineForm()
        {
            // Hide the login form
            loginForm.Hide();
            dashboardForm.Hide();
            quizForm.Hide();
            annoucementForm.Hide();
            assessmentForm.Hide();

            // Show the dashboard form inside the panel
            routineForm.TopLevel = false;
            routineForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(routineForm);
            routineForm.Show();
        }

        public void ShowQuizForm()
        {
            // Hide the login form
            loginForm.Hide();
            dashboardForm.Hide();
            routineForm.Hide();
            annoucementForm.Hide();
            assessmentForm.Hide();

            // Show the dashboard form inside the panel
            quizForm.TopLevel = false;
            quizForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(quizForm);
            quizForm.Show();
        }

        public void ShowAnnoucemnetForm()
        {
            // Hide the login form
            loginForm.Hide();
            dashboardForm.Hide();
            routineForm.Hide();
            quizForm.Hide();
            assessmentForm.Hide();

            // Show the dashboard form inside the panel
            annoucementForm.TopLevel = false;
            annoucementForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(annoucementForm);
            annoucementForm.Show();
        }

        public void ShowAssesmentForm()
        {
            // Hide the login form
            loginForm.Hide();
            dashboardForm.Hide();
            routineForm.Hide();
            quizForm.Hide();
            annoucementForm.Hide();

            // Show the dashboard form inside the panel
            assessmentForm.TopLevel = false;
            assessmentForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(assessmentForm);
            assessmentForm.Show();
        }

        private void menuButtonHome_Click(object sender, EventArgs e)
        {
            ShowDashboardForm();
        }

        private void menuButtonRoutine_Click(object sender, EventArgs e)
        {
            ShowRoutineForm();
        }

        private void menuButtonAnnoucemnet_Click(object sender, EventArgs e)
        {
            ShowAnnoucemnetForm();
        }

        private void menuButtonQuiz_Click(object sender, EventArgs e)
        {
            ShowQuizForm();
        }

        private void menuButtonAnalysis_Click(object sender, EventArgs e)
        {
            ShowAssesmentForm();
        }
    }
}
