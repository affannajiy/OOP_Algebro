using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement;

namespace LeaveTimeTrackingManagement
{
    public class TimeTracking : Employee
    {

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeTracking(string empName, int empID,  DateTime startTime, DateTime endTime)
            : base(empName, empID, string.Empty, "", string.Empty)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        // Method to calculate the total hours worked
        public double GetTotalHours()
        {
            TimeSpan timeSpent = EndTime - StartTime;
            return timeSpent.TotalHours; // Returns total hours as a double
        }
    }
}
