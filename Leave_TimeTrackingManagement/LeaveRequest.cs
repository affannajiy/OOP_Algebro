using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement;

namespace LeaveTimeTrackingManagement
{
    public class LeaveRequest : Employee
    {
        public string approvalStatus { get; set; }
        public DateTime leaveDate { get; set; }
        public int daysTaken { get; set; }

        public void addLeave()
        {

        }

        public void updateStatus()
        {

        }
    }
}
