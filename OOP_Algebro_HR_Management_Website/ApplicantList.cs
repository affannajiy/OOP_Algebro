using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class ApplicantList
    {
        private List<Applicant> applicants;

        public ApplicantList() 
        {
            applicants = new List<Applicant>();
        }
        public void AddApplicant(Applicant applicant)
        {
            applicants.Add(applicant);
        }
        public void RemoveApplicant(Applicant applicant)
        {
            applicants.Remove(applicant);
        }
        public void Display()
        {
            foreach (Applicant applicant in applicants)
            {
                Console.WriteLine(applicant.AppName);
            }
        }
        public void UpdateStatus()
        {
            string status;
            int appStatus = Convert.ToInt32(Console.ReadLine());
            if (appStatus == 0)
            {
                status = "Accepted";
            }
            else if (appStatus == 1)
            {
                status = "Rejected";
            }else
            {
                status = "Pending";
            }
      
        }
    }
}
