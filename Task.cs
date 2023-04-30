using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skedule
{
    internal class Task
    {
        public Subject Subject { get; set; }
        public string taskTag { get; set; }
        public string taskDetails { get; set; }
        public DateTime deadline { get; set; }
    }
}
