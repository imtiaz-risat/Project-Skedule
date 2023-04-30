using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skedule
{
    internal class Classroom
    {
        public string classCode { get; set; }
        public Routine routineSet { get; set; }
        public List<Subject> subjectList { get; set; } = new List<Subject>();
        public List<Exam> examList { get; set; } = new List<Exam>();
        public List<Task> taskList { get; set; } = new List<Task>();
        public List<Annoucement> annoucementList { get; set;} = new List<Annoucement>();

        // Discussion Section is yet to be added
    }
}
