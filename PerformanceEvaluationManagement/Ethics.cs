using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceEvaluationManagement
{
    public class Ethics
    {
        public int Merit { get; set; }

       public void meritList(int merit)
      {
        double totalMerit = 0;
        totalMerit += merit;
        Console.WriteLine("Merit: " + totalMerit);
      }
    }
}
