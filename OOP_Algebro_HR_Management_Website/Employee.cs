using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class Employee
    {
        public string employeeName { get; set; }
        public int employeeID { get; set; }
        public string employeePosition { get; set; }
        public int employeeContactNum { get; set; }
        public string employeeStatus { get; set; }

        public void EmployeeInfo
            (string employeeName, int employeeID, string employeePosition, int employeeContactNum, string employeeStatus)
        {
            //Console.WriteLine("Employee Name: " + employeeName);
            //Console.WriteLine("Employee ID: " + employeeID);
            //Console.WriteLine("Employee Position: " + employeePosition);
            //Console.WriteLine("Employee Contact Number: " + employeeContactNum);
            //Console.WriteLine("Employee Status: " + employeeStatus);
        }
    }
}
