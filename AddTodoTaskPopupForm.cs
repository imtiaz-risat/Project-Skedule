using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skedule
{
    public partial class AddTodoTaskPopupForm : UserControl
    {
        public Form1 parentForm { get; set; }
        public bool TopLevel { get; internal set; }

        public AddTodoTaskPopupForm()
        {
            InitializeComponent();
        }

        private void AddTodoTaskPopupForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            DateTime startDate = addTaskStartDate.Value.Date;
            DateTime endDate = addTaskEndDate.Value.Date;
            string taskDetails = addTaskTaskDetailsTextBox.Text;

            TodoTasks task = new TodoTasks(startDate, endDate, taskDetails);

            // Need to add to the tasklist of logged in user
            MessageBox.Show(parentForm.CurrentStudent.firstName);
            parentForm.CurrentStudent.todoTasks.Add(task);
        }
    }
}
