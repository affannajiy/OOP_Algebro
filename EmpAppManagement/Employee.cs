namespace EmpAppManagement
{
    public class Employee
    {
        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public string EmpPosition { get; set; }
        public string EmpContactNum { get; set; }
        public string EmpStatus { get; set; }

        public Employee(string empName, int empID, string empPosition, string empContactNum, string status)
        {
            EmpName = empName;
            EmpID = empID;
            EmpPosition = empPosition;
            EmpContactNum = empContactNum;
            EmpStatus = status;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Position: {EmpPosition}");
            Console.WriteLine($"Contact Number: {EmpContactNum}");
            Console.WriteLine($"Status: {EmpStatus}");
            Console.WriteLine("-------------------------------");
        }
    }
}
