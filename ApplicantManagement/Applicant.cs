using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantManagement
{
    public class Applicant
    {
        public string AppName { get; set; }
        public int AppContactNum { get; set; }
        public string AppRole { get; set; }
        public DateTime IvDate { get; set; }

        // Constructors
        public Applicant(string appName, int appContactNum, string appRole, DateTime ivDate)
        {
            AppName = appName;
            AppContactNum = appContactNum;
            AppRole = appRole;
            IvDate = ivDate;
        }

        // Default constructor
        public Applicant() { }

        // Display
        public void DisplayApplicantInfo()
        {
            Console.WriteLine($"Name: {AppName}, Contact: {AppContactNum}, Role: {AppRole}, Interview Date: {IvDate.ToShortDateString()}");
        }
    }
}