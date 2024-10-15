using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class ApplicantList
    {
        public string statusRecruitment;
        
        private List<Applicant> applicants;

        public ApplicantList() 
        {
            applicants = new List<Applicant>();
        }
        public ApplicantList(int num) 
        {
            applicants = new List<Applicant>(num);
        }
        public void Init(int num)
        {
            applicants = new List<Applicant>(num);
        }
        public void Add(Applicant applicant)
        {
            applicants.Add(applicant);
        }
        public void Remove(Applicant applicant)
        {
            applicants.Remove(applicant);
        }
        public void Display()
        {
            for (int i = 0; i < applicants.Count; i++)
            {
                Console.WriteLine(applicants[i].AppName);
            }
        }
        public void UpdateStatus()
        {
            int appStatus = Convert.ToInt32(Console.ReadLine());
            if (appStatus == 0)
            {
                statusRecruitment = "Accepted";
            }
            else if (appStatus == 1)
            {
                statusRecruitment = "Rejected";
            }
            else
            {
                statusRecruitment = "Pending";
            }
        }

    }
}
