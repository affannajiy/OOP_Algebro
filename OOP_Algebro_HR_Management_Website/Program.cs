using ApplicantManagement;
using EmployeeManagement;
using LeaveTimeTrackingManagement;
using PerformanceEvaluationManagement;
using FeedbackManagement;
using BenefitManagement;
using WorkProjectManagement;
using Leave_TimeTrackingManagement;

namespace HRManagement_Main
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Example for Applicant Info
            ApplicantList applicantList = new ApplicantList();
            Applicant applicant1 = new Applicant("Adam Marwan", "0123456789", "Software Engineer", new DateTime(2024, 1, 31, 14, 30, 0));
            Applicant applicant2 = new Applicant("Jamal Abdillah", "0136969607", "Cleaner", new DateTime(2024, 2, 20, 10, 30, 0));
            Applicant applicant3 = new Applicant("Siti Nabila", "0176678956", "Accountant", new DateTime(2024, 2, 21, 11, 35, 0));
            applicantList.Add(applicant1);
            applicantList.Add(applicant2);
            applicantList.Add(applicant3);
            applicantList.Display();

            //Example for Employee Info
            EmployeeList employeeList = new EmployeeList();
            Employee emp1 = new Employee("John Doe", 1001, "Manager", "0123556789", "Active");
            Employee emp2 = new Employee("Jane Smith", 1002, "Developer", "0198764321", "Active");
            Employee emp3 = new Employee("Emily Davis", 1003, "Designer", "0112233445", "On Leave");
            employeeList.AddEmployee(emp1);
            employeeList.AddEmployee(emp2);
            employeeList.AddEmployee(emp3);
            employeeList.DisplayAllEmployees();
            //RemoveEmployee()
            //FindEmployeeByID()

            FeedbackList feedbackList = new FeedbackList();

            KPI kPI = new KPI();

            //Example for Leave Request
            LeaveRequestList leaveRequestList = new LeaveRequestList();
            DateTime leaveDate1 = new DateTime(2024, 10, 20);
            DateTime leaveDate2 = new DateTime(2024, 11, 5);
            LeaveRequest leaveRequest1 = new LeaveRequest("John Doe", 1001, "Medical Leave", "Pending", leaveDate1, 5);
            LeaveRequest leaveRequest2 = new LeaveRequest("Jane Smith", 1002, "Family Emergency", "Pending", leaveDate2, 3);
            leaveRequestList.AddLeaveRequest(leaveRequest1);
            leaveRequestList.AddLeaveRequest(leaveRequest2);
            leaveRequestList.DisplayAllLeaveRequests();
            //RemoveLeaveRequest()
            //FindLeaveRequestByID()

            //Example for Time Tracking
            TimeTrackingList timeTrackingList = new TimeTrackingList();
            TimeTracking tt1 = new TimeTracking("John Doe", 1001, new DateTime(2024, 10, 15, 9, 0, 0), new DateTime(2024, 10, 15, 17, 0, 0));
            TimeTracking tt2 = new TimeTracking("Jane Smith", 1002, new DateTime(2024, 10, 14, 10, 0, 0), new DateTime(2024, 10, 14, 18, 0, 0));
            timeTrackingList.AddTimeTracking(tt1);
            timeTrackingList.AddTimeTracking(tt2);
            timeTrackingList.DisplayAllTimeTrackings();
            //RemoveTimeTracking()
            //FindTimeTrackingByID()

            BenefitList benefitList = new BenefitList();

            WorkProjectList workProjectList = new WorkProjectList();
        }
    }
}
