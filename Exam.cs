using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skedule
{
    internal class Exam
    {
        public Subject subject { get; set; }
        public int totalMarks { get; set; }
        public string syllabus { get; set; }
        public DateTime dateTime { get; set; }
        public string roomNo { get; set; }

    }
}
