//Contributor: Adham, Affan, Iman
namespace HRManagement
{
    public class WorkProjectList
    {
        // initiating list
        public List<Work> WorkProjects { get; set; }

        // Constructor
        public WorkProjectList()
        {
            WorkProjects = new List<Work>();
        }

        // Method for adding a project
        public void AddWorkProject(Work work)
        {
            WorkProjects.Add(work);
        }

        // Display method
        public void DisplayAllWorkProjects()
        {
            Console.WriteLine("Work Project List:");
            Console.WriteLine("-------------------------------");
            foreach (Work work in WorkProjects)
            {
                work.DisplayWorkDetails();
            }
            Console.WriteLine();
        }
    }
}
