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
        // Login Status
        public Student CurrentStudent;

        // All Child forms
        private LoginChildForm loginForm;
        private DashboardChildForm dashboardForm;
        private RoutineChildForm routineForm;
        private QuizChildForm quizForm;
        private AnnouncementChildForm annoucementForm;
        private AssessmentChildForm assessmentForm;
        private AddTodoTaskPopupForm addTodoTaskPopupForm;

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
            addTodoTaskPopupForm= new AddTodoTaskPopupForm();


            CurrentStudent = new Student("Admin", "123", "Imtiaz", "Risat", "imtiaz@gamil.com", DateTime.Now);
            CurrentStudent.parentForm = this;


            // Set the parent form for the child forms
            loginForm.parentForm = this;
            dashboardForm.parentForm = this;
            routineForm.parentForm = this;
            quizForm.parentForm = this;
            annoucementForm.parentForm = this;
            assessmentForm.parentForm = this;
            addTodoTaskPopupForm.parentForm= this;

        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            // Code to open the LogincChildForm inside the panel
            ShowLoginForm();
        }

        public void HideAllChildForms()
        {
            dashboardForm.Hide();
            routineForm.Hide();
            quizForm.Hide();
            annoucementForm.Hide();
            assessmentForm.Hide();
            loginForm.Hide();
            addTodoTaskPopupForm.Hide();
        }

        public void ShowLoginForm()
        {
            // Hide the dashboard form
            HideAllChildForms();

            // Show the login form inside the panel
            loginForm.TopLevel = false;
            loginForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(loginForm);
            loginForm.Show();
        }


        public void ShowDashboardForm()
        {
            // Hide the other forms
            HideAllChildForms();

            // Show the dashboard form inside the panel
            dashboardForm.TopLevel = false;
            dashboardForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }

        public void ShowRoutineForm()
        {
            // Hide the login form
            HideAllChildForms();

            // Show the dashboard form inside the panel
            routineForm.TopLevel = false;
            routineForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(routineForm);
            routineForm.Show();
        }

        public void ShowQuizForm()
        {
            // Hide the login form
            HideAllChildForms();

            // Show the dashboard form inside the panel
            quizForm.TopLevel = false;
            quizForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(quizForm);
            quizForm.Show();
        }

        public void ShowAnnoucemnetForm()
        {
            // Hide the login form
            HideAllChildForms();

            // Show the dashboard form inside the panel
            annoucementForm.TopLevel = false;
            annoucementForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(annoucementForm);
            annoucementForm.Show();
        }

        public void ShowAssesmentForm()
        {
            // Hide the login form
            HideAllChildForms();

            // Show the dashboard form inside the panel
            assessmentForm.TopLevel = false;
            assessmentForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(assessmentForm);
            assessmentForm.Show();
        }

        public void ShowAddTaskPopUpForm()
        {
            HideAllChildForms();

            addTodoTaskPopupForm.TopLevel = false;
            addTodoTaskPopupForm.Dock = DockStyle.Top;
            childFormPanel.Controls.Add(addTodoTaskPopupForm);
            addTodoTaskPopupForm.Show();
        }

        public bool LoginStatus()
        {
            return CurrentStudent.isLoggedin;
        }

        private void menuButtonHome_Click(object sender, EventArgs e)
        {
            if (LoginStatus())
                ShowDashboardForm();
        }

        private void menuButtonRoutine_Click(object sender, EventArgs e)
        {
            if (LoginStatus())
                ShowRoutineForm();
        }

        private void menuButtonAnnoucemnet_Click(object sender, EventArgs e)
        {
            if (LoginStatus())
                ShowAnnoucemnetForm();
        }

        private void menuButtonQuiz_Click(object sender, EventArgs e)
        {
            if (LoginStatus())
                ShowQuizForm();
        }

        private void menuButtonAnalysis_Click(object sender, EventArgs e)
        {
            if (LoginStatus())
                ShowAssesmentForm();
        }
    }
}
