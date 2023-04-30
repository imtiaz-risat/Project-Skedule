using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skedule
{
    internal class Lecture
    {
        public Subject subject { get; set; }
        public string teacherName { get; set; }
        public string roomNo { get; set; }
        public DateTime timePeriod { get; set; }

    }
}
