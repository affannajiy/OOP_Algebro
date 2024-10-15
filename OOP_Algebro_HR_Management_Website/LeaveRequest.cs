using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement;

namespace OOP_Algebro_HR_Management_Website
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
