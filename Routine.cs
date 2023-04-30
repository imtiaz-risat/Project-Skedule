using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skedule
{
    internal class Routine
    {
        public List<Lecture> monRoutine { get; set; } = new List<Lecture>();
        public List<Lecture> tueRoutine { get; set; } = new List<Lecture>();
        public List<Lecture> wedRoutine { get; set; } = new List<Lecture>();
        public List<Lecture> thuRoutine { get; set; } = new List<Lecture>();
        public List<Lecture> friRoutine { get; set; } = new List<Lecture>();
        public List<Lecture> satRoutine { get; set; } = new List<Lecture>();
        public List<Lecture> sunRoutine { get; set; } = new List<Lecture>();
    }
}
