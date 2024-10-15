using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProjectManagement
{
    public class Work
    {
        public double WorkProgress { get; set; } // in percentage pls
        public int StartWorkTime { get; set; } // in hour
        public int EndWorkTime { get; set; } // in hour
        public string WorkStatus { get; set; } // 

        // Constructor
        public Work(double progress, int start, int end, string status)
        {
            WorkProgress = progress;
            StartWorkTime = start;
            EndWorkTime = end;
            WorkStatus = status;
        }

        // Method for work that has been done (100%) only
        public void WorkCompleted()
        {
            WorkStatus = "Completed";
            WorkProgress = 100.0;
        }

        // Method for total hours worked
        public int TotalWorkHours()
        {
            return EndWorkTime - StartWorkTime;
        }

/*
        Example of output for work.cs (using object yg dh ada input untuk tunjuk example output)
        // Create a Work object for a new project that hasn't started & display
        Work notStartedWork = new Work(0.0, 14, 22, "Not Started");
        notStartedWork.DisplayWorkDetails();

        Output:
        Work Status: Not Started, Progress: 0.00%, Total Hours: 8
*/
        
        // Display method
        public void DisplayWorkDetails()
        {
            Console.WriteLine($"Work Status: {WorkStatus}, Progress: {WorkProgress:F2}%, Total Hours: {TotalWorkHours()}");
        }
    }
}

