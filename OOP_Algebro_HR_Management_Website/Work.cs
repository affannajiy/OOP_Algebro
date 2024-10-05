using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class Work
    {
        public double workProgress { get; set; } //percentage
        public int startWorkTime { get; set; }
        public int endWorkTime { get; set; }
        public string workStatus { get; set; }

        public void WorkCompleted()
        {

        }
    }
}
