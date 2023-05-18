using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skedule
{
    public class TodoTasks
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string taskDetails { get; set; }
        
        public bool isCompleted = false;

        public TodoTasks(DateTime startDate, DateTime endDate, string taskDetails)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.taskDetails = taskDetails;
        }

        public override string ToString()
        {
            return $"{startDate:d} - {endDate:d} - {taskDetails:d} - {(isCompleted ? "Completed" : "Incomplete")}";
        }
    }
}
