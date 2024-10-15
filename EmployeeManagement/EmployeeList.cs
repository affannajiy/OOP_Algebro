using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeList
    {
        public List<Employee> Employees { get; set; }

        // Constructor to initialize the employee list
        public EmployeeList()
        {
            Employees = new List<Employee>();
        }

        // Method to add an employee to the list
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Console.WriteLine($"Employee {employee.EmpName} added successfully.");
        }

        // Method to remove an employee by employee ID
        public void RemoveEmployee(int empID)
        {
            Employee employee = Employees.Find(e => e.EmpID == empID);
            if (employee != null)
            {
                Employees.Remove(employee);
                Console.WriteLine($"Employee {employee.EmpName} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Employee with ID {empID} not found.");
            }
        }

        // Method to display all employees in the list
        public void DisplayAllEmployees()
        {
            Console.WriteLine("Employee List:");
            Console.WriteLine("-------------------------------");
            foreach (Employee employee in Employees)
            {
                employee.DisplayEmployeeInfo();
            }
            Console.WriteLine();
        }

        // Method to find and display employee details by ID
        public void FindEmployeeByID(int empID)
        {
            Employee employee = Employees.Find(e => e.EmpID == empID);
            if (employee != null)
            {
                employee.DisplayEmployeeInfo();
            }
            else
            {
                Console.WriteLine($"Employee with ID {empID} not found.");
            }
        }
    }
}
