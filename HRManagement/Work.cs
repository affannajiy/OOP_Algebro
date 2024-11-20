//Contributor: Adham
namespace HRManagement
{
    public class Work
    {
        public double WorkProgress { get; set; } // in percentage 
        public string ProjectTitle { get; set; }

        // Constructor
        public Work(double progress, string title)
        {
            WorkProgress = progress;
            ProjectTitle = title;
        }
        
        // Display method
        public void DisplayWorkDetails()
        {
            Console.WriteLine($"Project Title: {ProjectTitle}");
            Console.WriteLine($"Progress: {WorkProgress:F2}");
            Console.WriteLine("-------------------------------");
        }
    }
}

