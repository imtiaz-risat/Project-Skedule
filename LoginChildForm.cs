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
    public partial class LoginChildForm : UserControl
    {
        public List<Student> studentsList;

        public bool TopLevel { get; internal set; }

        public Form1 parentForm { get; set; }

        public LoginChildForm()
        {
            InitializeComponent();
           studentsList = new List<Student>();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxLoginUsername.Text;
            string password = textBoxLoginPassword.Text;

            // Check if the student exists
            Student student = studentsList.Find(s => s.username == username);

            if (student != null && student.password == password)
            {
                MessageBox.Show("Login successful!");
                // After successful login
                student.isLoggedin = true;
                parentForm.CurrentStudent = student;
                parentForm.ShowDashboardForm();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string email = textBoxSignupEmail.Text;
            string username = textBoxSignupUsername.Text;
            string password = textBoxSignupPassword.Text;
            string confirmPassword = textBoxSignupConfirmPass.Text;
            string firstname = textBoxSignupFirstname.Text;
            string lastname = textBoxSignupLastname.Text;
            DateTime birthdate = birthdatePickerSignup.Value;

            // Check if all fields are filled
            if (textBoxSignupEmail.Text == "" ||
            textBoxSignupUsername.Text == "" ||
            textBoxSignupPassword.Text == "" ||
            textBoxSignupConfirmPass.Text == "" ||
            textBoxSignupFirstname.Text == "" ||
            textBoxSignupLastname.Text == "")
            {
                MessageBox.Show("Please fillup all the required fields!");
                return;
            }

            // Check if confirm password matches
            if (password !=  confirmPassword)
            {
                MessageBox.Show("Confrim password doesn't match. Please re-enter correctly!");
                return;
            }
            // Check if the username already exists
            if (studentsList.Exists(s => s.username == username))
            {
                MessageBox.Show("Username already exists. Please choose a different username!");
                return;
            }

            // Create a new student
            Student student = new Student(username, password, firstname, lastname, email, birthdate);
            studentsList.Add(student);

            MessageBox.Show("Signup successful. You may login now!\n Your Student Id: " + student.id);

            // Clear the signup form
            textBoxSignupEmail.Text = "";
            textBoxSignupUsername.Text = "";
            textBoxSignupPassword.Text = "";
            textBoxSignupConfirmPass.Text = "";
            textBoxSignupFirstname.Text = "";
            textBoxSignupLastname.Text = "";
            birthdatePickerSignup.Value = DateTime.Now;
        }

    }
}
