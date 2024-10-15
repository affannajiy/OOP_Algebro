using ApplicantManagement;
using EmployeeManagement;
using LeaveTimeTrackingManagement;
using PerformanceEvaluationManagement;
using FeedbackManagement;

namespace HRManagement_Main
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