//Github Link: https://github.com/affannajiy/OOP_Algebro
using EmpAppManagement; //EmployeeApplicantManagement: Employee & Applicant Features
using HRManagement; //HRManagement: HR Features & Functionalities
using HRDatabaseManagement;
using FirebaseAdmin.Messaging;
using static Google.Rpc.Context.AttributeContext.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;

namespace HRApplication
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Example for Applicant Info
            ApplicantList applicantList = new ApplicantList();
            Applicant applicant1 = new Applicant("Adam Marwan", "0123456789", "Software Engineer", new DateTime(2024, 5, 28, 8, 0, 0), 800);
            Applicant applicant2 = new Applicant("Jamal Abdillah", "0136969607", "Cleaner", new DateTime(2024, 5, 29, 8, 0, 0), 801);
            Applicant applicant3 = new Applicant("Siti Nurhaliza", "0176678956", "Accountant", new DateTime(2024, 5, 30, 8, 0, 0), 802);
            applicantList.AddApplicant(applicant1);
            applicantList.AddApplicant(applicant2);
            applicantList.AddApplicant(applicant3);
            applicantList.DisplayAllApplicants();
            //RemoveApplicant()
            //FindApplicantByName()

            //Example for Employee Info
            EmployeeList employeeList = new EmployeeList();
            Employee emp1 = new Employee("M. Nasir", 1001, "Manager", "0123556789", "Active");
            Employee emp2 = new Employee("Sheila Majid", 1002, "Developer", "0198764321", "Active");
            Employee emp3 = new Employee("Francisca Peter", 1003, "Designer", "0112233445", "On Leave");
            employeeList.AddEmployee(emp1);
            employeeList.AddEmployee(emp2);
            employeeList.AddEmployee(emp3);
            employeeList.DisplayAllEmployees();
            //RemoveEmployee()
            //FindEmployeeByID()

            //Example for Feedback
            FeedbackList feedbackList = new FeedbackList();
            Feedback feedback1 = new Feedback(1001, "Excellent, I love the company.");
            Feedback feedback2 = new Feedback(1002, "The company is meh, I am okay.");
            feedbackList.AddFeedback(feedback1);
            feedbackList.AddFeedback(feedback2);
            feedbackList.DisplayAllFeedbacks();
            //RemoveFeedBack()

            // Example for Work list
            WorkProjectList workProjectList = new WorkProjectList();
            Work project1 = new Work(100.0, "Stellar Nexus");
            Work project2 = new Work(100.0, "Quantum Horizon");
            Work project3 = new Work(50.0, "EchoForge");
            workProjectList.AddWorkProject(project1);
            workProjectList.AddWorkProject(project2);
            workProjectList.AddWorkProject(project3);
            workProjectList.DisplayAllWorkProjects();

            //Example for Performance
            Performance work1 = new Performance("Quantum Horizon", 100, "No");
            work1.UpdateWorkCompletion();

            //Example for Ethics / Merit
            Ethics employeeEthics = new Ethics(1002, 50);
            employeeEthics.DeductMerit("Late to work");
            employeeEthics.DeductMerit("Insubordination");
            employeeEthics.DisplayMerit();
            //DisplayViolations()

            //Example for KPI
            KPI employeeKPI = new KPI(1001, 2, 42.0, 28);
            employeeKPI.DisplayKPI();

            //Example for Leave Request List
            LeaveRequestList leaveRequestList = new LeaveRequestList();
            DateTime leaveDate1 = new DateTime(2024, 10, 20);
            DateTime leaveDate2 = new DateTime(2024, 11, 5);
            LeaveRequest leaveRequest1 = new LeaveRequest("John Doe", 1001, "Medical Leave", "Approved", leaveDate1, 5);
            LeaveRequest leaveRequest2 = new LeaveRequest("Jane Smith", 1002, "Family Emergency", "Pending", leaveDate2, 3);
            leaveRequestList.AddLeaveRequest(leaveRequest1);
            leaveRequestList.AddLeaveRequest(leaveRequest2);
            leaveRequestList.DisplayAllLeaveRequests();
            //RemoveLeaveRequest()
            //FindLeaveRequestByID()

            //Example for Time Tracking List
            TimeTrackingList timeTrackingList = new TimeTrackingList();
            TimeTracking tt1 = new TimeTracking("John Doe", 1001, new DateTime(2024, 10, 15, 9, 0, 0), new DateTime(2024, 10, 15, 17, 0, 0));
            TimeTracking tt2 = new TimeTracking("Jane Smith", 1002, new DateTime(2024, 10, 14, 10, 0, 0), new DateTime(2024, 10, 14, 18, 0, 0));
            timeTrackingList.AddTimeTracking(tt1);
            timeTrackingList.AddTimeTracking(tt2);
            timeTrackingList.DisplayAllTimeTrackings();
            //RemoveTimeTracking()
            //FindTimeTrackingByID()

            //Example for Benefit List
            BenefitList benefitList = new BenefitList();
            Benefit emp1b = new Benefit(1001, 95.0); // High KPI
            Benefit emp2b = new Benefit(1002, 65.0); // Medium KPI
            Benefit emp3b = new Benefit(1003, 45.0); // Low KPI
            emp1b.AssignBenefitsBasedOnKPI(); 
            emp2b.AssignBenefitsBasedOnKPI(); 
            emp3b.AssignBenefitsBasedOnKPI(); 
            benefitList.AddBenefit(emp1b); 
            benefitList.AddBenefit(emp2b);
            benefitList.AddBenefit(emp3b);
            benefitList.DisplayAllBenefits();
            //RemoveBenefit()
            //FindBenefitByID()

            //Firestore
            FirestoreManager firestoremanager = new FirestoreManager();
            firestoremanager.initFirestore();

            //Employee
            var task1e = Task.Run(async () => await firestoremanager.SaveEmployee(emp1)); //test emp1
            task1e.Wait();
            var task2e = Task.Run(async () => await firestoremanager.SaveEmployee(emp2)); //test emp2
            task2e.Wait();
            var task3e = Task.Run(async () => await firestoremanager.SaveEmployee(emp3)); //test emp3
            task3e.Wait(); //Blocks until task is done

            //Employee - Methods
            var task4e = Task.Run(async () => await firestoremanager.RemoveEmployee("1002"));
            task4e.Wait();
            var task5e = Task.Run(async () => await firestoremanager.ReadAllEmployees());
            task5e.Wait();

            //Applicant
            var task1a = Task.Run(async () => await firestoremanager.SaveApplicant(applicant1));
            task1a.Wait();
            var task2a = Task.Run(async () => await firestoremanager.SaveApplicant(applicant2));
            task2a.Wait();
            var task3a = Task.Run(async () => await firestoremanager.SaveApplicant(applicant3));
            task3a.Wait();

            //Applicant - Methods
            var task4a = Task.Run(async () => await firestoremanager.RemoveApplicant("801"));
            task4a.Wait();
            var task5a = Task.Run(async () => await firestoremanager.ReadAllApplicants());
            task5a.Wait();
        }
    }
}