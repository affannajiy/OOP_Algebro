using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeList
    {
        private List<Employee> employees;

        public EmployeeList()
        {
          employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            /*
            Console.WriteLine("Add Employee");
            Console.WriteLine("Enter Employee Name: ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee ID: ");
            int employeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Position: ");
            string employeePosition = Console.ReadLine();
            Console.WriteLine("Enter Employee Contact Number: ");
            int employeeContactNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Status: ");
            string employeeStatus = Console.ReadLine()
            */
        }

        public void RemoveEmployee(Employee employee)
        {
          employees.Remove(employee);
        }

        public void DisplayEmployeeList()
        {
          foreach (Employee employee in employees)
          {
              Console.WriteLine(employee.EmpName);
          }
        }
    }
}
