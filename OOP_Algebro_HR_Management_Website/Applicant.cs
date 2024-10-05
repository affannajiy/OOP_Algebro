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
        
        public int AppContactNum { get; set; }

        public string AppRole { get; set; }

        public Date IvDate = new Date();

        public appInfo(string appName, int appContactNum, string appRole, Date ivDate)
        {
            AppName = appName; AppContactNum = appContactNum; AppRole = appRole; IvDate = ivDate;
        }

        public Applicant() { }
    }
}
