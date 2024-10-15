using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceEvaluationManagement
{
    public class Performance
    {
        public int workCompleted { get; set; }

        public void totalWorkCompleted(int workcompleted)
        {
            double totalWorkCompleted = 0;
            totalWorkCompleted += workcompleted;
            Console.WriteLine("Total Work Completed: " + totalWorkCompleted);
        }
    }
}
