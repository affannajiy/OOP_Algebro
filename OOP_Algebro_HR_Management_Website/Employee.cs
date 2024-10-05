using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class Employee
    {
        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public string EmpPosition { get; set; }
        public int EmpContactNum { get; set; }
        public string EmpStatus { get; set; }

        public void EmployeeInfo(string empName, int empID, string empPosition, int empContactNum, string status)
        {
            EmpName = empName;
            EmpID = empID;
            EmpPosition = empPosition;
            EmpContactNum = empContactNum;
            EmpStatus = status;
        }
    }
}
