using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skedule
{
    public partial class DashboardChildForm : UserControl
    {
        public Form1 parentForm { get; set; }
        public bool TopLevel { get; internal set; }

        public DashboardChildForm()
        {
            InitializeComponent();

            TodoTaskList_Load();
        }

        private void DashboardChildForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddTaskDashboard_Click(object sender, EventArgs e)
        {
            parentForm.ShowAddTaskPopUpForm();
        }

        private void TodoTaskList_Load()
        {
            /*listTodoTask.Items.Clear();
            if (parentForm.CurrentStudent != null) {
                foreach (TodoTasks task in parentForm.CurrentStudent.todoTasks)
                {
                    listTodoTask.Items.Add($"{task.startDate:d}\t{task.endDate:d} - {task.taskDetails:d} - {(task.isCompleted ? "Completed" : "Incomplete")}");
                }
            }*/
        }
    }
}
