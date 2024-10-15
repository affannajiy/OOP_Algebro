using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProjectManagement
{
    public class Work
    {
        public double workProgress { get; set; } //percentage
        public int startWorkTime { get; set; }
        public int endWorkTime { get; set; }
        public string workStatus { get; set; }

        //Constructor
        public Work(double progress, int start, int end, string status)
        {
            workProgress = progress;
            startWorkTime = start;
            endWorkTime = end;
            workStatus = status;
        }

        public void WorkCompleted()
        {

        }
    }
}
