//Contributor: Adham
namespace EmpAppManagement
{
    public class EmployeeList
    {
        public List<Employee> Employees { get; set; }

        //Constructor to initialize the employee list
        public EmployeeList()
        {
            Employees = new List<Employee>();
        }

        //AddEmployee
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Console.WriteLine($"Employee {employee.EmpName} added successfully.");
        }

        //RemoveEmployee
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

        //DisplayAllEmployees
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

        //FindEmployeeByID
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
