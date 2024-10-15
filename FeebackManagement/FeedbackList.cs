using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackManagement
{
    public class FeedbackList
    {
        public string feedbackStatus { get; set; }
        public FeedBack feedback { get; set; }
        
        private List<FeedBack> feedbackList = new List<FeedBack>();

        public void UpdateStatus()
        {
            Console.WriteLine("The feedback status: + feedback");
        }
    }
}
