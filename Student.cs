using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Skedule
{
    public class Student
    {
        internal Form1 parentForm;

        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public string emailAddress { get; set; }
        public List<TodoTasks> todoTasks { get; set; }


        public Student(string userName, string passWord, string firstname, string lastname, string email, DateTime birthday)
        {
            // Generate a unique ID for the student (you can modify this as needed)
            id = Guid.NewGuid().GetHashCode();
            username = userName;
            password = passWord;
            firstName = firstname;
            lastName = lastname;
            emailAddress = email;
            birthDate = birthday;
        }
    }


    
}
