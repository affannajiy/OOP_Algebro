using LeaveTimeTrackingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_TimeTrackingManagement
{
    public class LeaveRequestList
    {
        // List to hold LeaveRequest objects
        private List<LeaveRequest> leaveRequests;

        // Constructor to initialize the leave request list
        public LeaveRequestList()
        {
            leaveRequests = new List<LeaveRequest>();
        }

        // Method to add a leave request
        public void AddLeaveRequest(LeaveRequest leaveRequest)
        {
            leaveRequests.Add(leaveRequest);
            Console.WriteLine($"Leave request added for {leaveRequest.EmpName} ({leaveRequest.EmpID}).");
        }

        // Method to remove a leave request by employee ID
        public void RemoveLeaveRequest(int empID)
        {
            LeaveRequest leaveRequest = leaveRequests.Find(lr => lr.EmpID == empID);
            if (leaveRequest != null)
            {
                leaveRequests.Remove(leaveRequest);
                Console.WriteLine($"Leave request removed for {leaveRequest.EmpName} ({leaveRequest.EmpID}).");
            }
            else
            {
                Console.WriteLine($"Leave request for Employee ID {empID} not found.");
            }
        }

        // Method to display all leave requests
        public void DisplayAllLeaveRequests()
        {
            Console.WriteLine("Leave Requests List:");
            Console.WriteLine("-------------------------------");
            foreach (LeaveRequest leaveRequest in leaveRequests)
            {
                leaveRequest.DisplayLeaveRequestInfo();
            }
        }

        // Method to find and display leave request by employee ID
        public void FindLeaveRequestByID(int empID)
        {
            LeaveRequest leaveRequest = leaveRequests.Find(lr => lr.EmpID == empID);
            if (leaveRequest != null)
            {
                leaveRequest.DisplayLeaveRequestInfo();
            }
            else
            {
                Console.WriteLine($"Leave request for Employee ID {empID} not found.");
            }
        }
    }
}
