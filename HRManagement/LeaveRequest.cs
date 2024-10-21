using EmpAppManagement;

namespace HRManagement
{
    public class LeaveRequest : Employee
    {
        // Properties
        public string Reason { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime LeaveDate { get; set; }
        public int DaysTaken { get; set; }

        // Constructor
        public LeaveRequest(string empName, int empID, string reason, string approvalStatus, DateTime leaveDate, int daysTaken)
            : base(empName, empID, string.Empty, "", string.Empty) // Calling base constructor
        {
            Reason = reason;
            ApprovalStatus = approvalStatus;
            LeaveDate = leaveDate;  // Set to the specific date provided
            DaysTaken = daysTaken;
        }
        // Method to display leave request details
        public void DisplayLeaveRequestInfo()
        {
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Leave Reason: {Reason}");
            Console.WriteLine($"Approval Status: {ApprovalStatus}");
            Console.WriteLine($"Leave Date: {LeaveDate.ToShortDateString()}");
            Console.WriteLine($"Days Taken: {DaysTaken}");
            Console.WriteLine("-------------------------------");
        }
    }
}
