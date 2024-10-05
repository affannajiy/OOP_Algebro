using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class Date : Applicant
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public Date(string day, string month, string year)
        {
            this.day = Day;
            this.month = Month;
            this.year = Year;
        }
    }
}
