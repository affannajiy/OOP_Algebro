using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackManagement
{
    public class FeedBack
    {
        public int ID { get; set; }
        public string Feedback { get; set; }

        //Constructor
        public FeedBack(int id, string feedback)
        {
            ID = id;
            Feedback = feedback;
        }
        public void AddFeedback()
        {
            //Console.WriteLine("Feedback: " + feedback)
        }
    }
}
