//Contributor: Affan
namespace EmpAppManagement
{
    public class ApplicantList
    {
        public string StatusRecruitment { get; set; }
        public List<Applicant> applicants {get; set;}

        //Constructor
        public ApplicantList()
        {
            applicants = new List<Applicant>();
        }

        //Constructor with Size
        public ApplicantList(int num) 
        {
            applicants = new List<Applicant>(num);
        }

        //Initialise with Size
        public void Init(int num)
        {
            applicants = new List<Applicant>(num);
        }

        //AddApplicant
        public void AddApplicant(Applicant applicant)
        {
            applicants.Add(applicant);
            Console.WriteLine($"Applicant {applicant.AppName} added successfully.");
        }

        //RemoveApplicant
        public void RemoveApplicant(Applicant applicant)
        {
            Applicant applicantToRemove = applicants.Find(a => a.AppName.Equals(applicant.AppName, StringComparison.OrdinalIgnoreCase));
            if (applicantToRemove != null)
            {
                applicants.Remove(applicantToRemove);
                Console.WriteLine($"Applicant {applicantToRemove.AppName} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Applicant with name {applicant.AppName} not found.");
            }
        }

        //DisplayAllApplicants
        public void DisplayAllApplicants()
        {
            if (applicants.Count == 0)
            {
                Console.WriteLine("No applicants in the list.");
                return;
            }

            Console.WriteLine("Applicant List:");
            Console.WriteLine("-------------------------------");
            foreach (Applicant applicant in applicants)
            {
                applicant.DisplayApplicantInfo();
            }
            Console.WriteLine();
        }

        //Update
        public void UpdateStatus(int appStatus)
        {
            switch (appStatus)
            {
                case 0:
                    StatusRecruitment = "Accepted";
                    break;
                case 1:
                    StatusRecruitment = "Rejected";
                    break;
                default:
                    StatusRecruitment = "Pending";
                    break;
            }

            Console.WriteLine($"Recruitment status updated to: {StatusRecruitment}");
        }
    }
}
