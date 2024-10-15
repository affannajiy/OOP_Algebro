using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class FeedbackList
    {
        public string feedbackStatus { get; set; }
        public FeedBack feedback { get; set; }
        
        public void UpdateStatus()
        {
          Console.WriteLine("The feedback status: + feedback");
        }
    }
}
