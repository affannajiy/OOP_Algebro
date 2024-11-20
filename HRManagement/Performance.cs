//Contributor: Adham, Affan
using HRManagement;

namespace HRManagement
{
    public class Performance : Work
    {
        public List<Work> WorkProjects = new List<Work>();
        // Property to track whether work is completed
        public string WorkCompleted { get; set; }

        // Constructor to initialize the performance with progress and completed work status
        public Performance(string title, double progress, string completed)
            : base(progress, title)
        {
            WorkCompleted = completed;
        }

        // Method to track total work completed
        public int TotalWorkCompleted { get; private set; } = 0;

        // Method to update total work completed if progress is 100%
        public void UpdateWorkCompletion()
        {
            foreach (Work work in WorkProjects)
            {
                if (WorkProgress == 100)
                {
                    TotalWorkCompleted++;
                    WorkCompleted = "Yes"; // Mark the work as completed
                    Console.WriteLine($"Work '{ProjectTitle}' is completed. Total completed work count: {TotalWorkCompleted}");
                }
                else
                {
                    WorkCompleted = "No"; // Work is not yet completed
                    Console.WriteLine($"Work '{ProjectTitle}' is still in progress with {WorkProgress}% completed.");
                }
            }
        }
    }
}
