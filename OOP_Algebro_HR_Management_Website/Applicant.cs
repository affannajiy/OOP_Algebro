using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class Applicant
    {
        public string AppName { get; set; }
        
        public int AppContactNumber { get; set; }

        public string AppRole { get; set; }

        public Date IvDate = new Date();
        
        public Position CurrPosition { get; set; }

        public Applicant(string name, int contactNumber, string role, Date ivDate)
        {
            AppName = name; AppContactNumber = contactNumber; AppRole = role; IvDate = ivDate;
        }

        public Applicant() { }
    }
}
