using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            ApplicantList applicantList = new ApplicantList();

            EmployeeList employeeList = new EmployeeList();

            FeedbackList feedbackList = new FeedbackList();

            KPI kPI = new KPI();

            LeaveRequest leaveRequest = new LeaveRequest();

            TimeTrackingList timeTrackingList = new TimeTrackingList();
        }
    }
}
