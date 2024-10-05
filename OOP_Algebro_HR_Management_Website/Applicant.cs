using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class Applicant
    {
        public Date ivDate = new Date();
        public string appName {get; set;}
        public int appContactNum {get; set;}
        public string appRole {get; set;}

        public void ApplicantInfo(string appName, int appContactNum, string appRole)
        {

        }
    }
}
