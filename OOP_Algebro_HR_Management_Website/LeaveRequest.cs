using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class LeaveRequest : Employee
    {
        public string approvalStatus { get; set; }
        public Date leaveDate { get; set; }
        public int daysTaken { get; set; }

        public void addLeave()
        {

        }

        public void updateStatus()
        {

        }
    }
}
