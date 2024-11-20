//Contributor: Adham
using EmpAppManagement;

namespace HRManagement
{
    public class TimeTrackingList
    {
        // List to hold TimeTracking objects
        private List<TimeTracking> timeTrackings;

        // Constructor to initialize the time tracking list
        public TimeTrackingList()
        {
            timeTrackings = new List<TimeTracking>();
        }

        // Method to add a TimeTracking entry
        public void AddTimeTracking(TimeTracking timeTracking)
        {
            timeTrackings.Add(timeTracking);
            Console.WriteLine($"Time tracking added for {timeTracking.EmpName} (ID: {timeTracking.EmpID}).");
        }

        // Method to remove a TimeTracking entry by employee ID
        public void RemoveTimeTracking(int empID)
        {
            TimeTracking timeTracking = timeTrackings.Find(tt => tt.EmpID == empID);
            if (timeTracking != null)
            {
                timeTrackings.Remove(timeTracking);
                Console.WriteLine($"Time tracking removed for {timeTracking.EmpName} (ID: {timeTracking.EmpID}).");
            }
            else
            {
                Console.WriteLine($"Time tracking for Employee ID {empID} not found.");
            }
        }

        // Method to display all time tracking entries
        public void DisplayAllTimeTrackings()
        {
            Console.WriteLine("Time Tracking List:");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-20} {1,-10} {2,-20} {3,-20} {4,-10}", "Employee Name", "Emp ID", "Start Time", "End Time", "Total Hours");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            foreach (TimeTracking timeTracking in timeTrackings)
            {
                Console.WriteLine("{0,-20} {1,-10} {2,-20} {3,-20} {4,-10:F2}",
                    timeTracking.EmpName,
                    timeTracking.EmpID,
                    timeTracking.StartTime.ToString("yyyy-MM-dd HH:mm"),
                    timeTracking.EndTime.ToString("yyyy-MM-dd HH:mm"),
                    timeTracking.GetTotalHours());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }

        // Method to find and display TimeTracking entry by employee ID
        public void FindTimeTrackingByID(int empID)
        {
            TimeTracking timeTracking = timeTrackings.Find(tt => tt.EmpID == empID);
            if (timeTracking != null)
            {
                Console.WriteLine($"Employee: {timeTracking.EmpName}, ID: {timeTracking.EmpID}, Start Time: {timeTracking.StartTime}, End Time: {timeTracking.EndTime}, Total Hours: {timeTracking.GetTotalHours():F2}");
            }
            else
            {
                Console.WriteLine($"Time tracking for Employee ID {empID} not found.");
            }
        }
    }
}
