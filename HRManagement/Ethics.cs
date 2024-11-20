//Contributor: Adham
using EmpAppManagement;

namespace HRManagement
{
    public class Ethics : Employee
    {
        // Property for Merit points
        public int Merit { get; set; }

        // Dictionary to hold violations and corresponding merit deductions
        private Dictionary<string, int> violations;

        // Constructor to initialize employee and merit points
        public Ethics(int empID, int merit)
            : base(string.Empty, empID, string.Empty, "", string.Empty)
        {
            Merit = merit;

            // Predefined violations and their merit deductions
            violations = new Dictionary<string, int>
            {
                { "Late to work", 5 },
                { "Unprofessional behavior", 10 },
                { "Missed deadline", 8 },
                { "Insubordination", 15 },
                { "Dress code violation", 3 }
            };
        }
        
        // Method to adjust merit based on violation
        public void DeductMerit(string violation)
        {
            if (violations.ContainsKey(violation))
            {
                int deduction = violations[violation];
                Merit -= deduction;
                Console.WriteLine($"ID: {EmpID} | Violation: {violation} (-{deduction} merit points). Remaining Merit: {Merit}");
            }
            else
            {
                Console.WriteLine($"Violation '{violation}' not recognized.");
            }
        }

        // Method to display available violations
        public void DisplayViolations()
        {
            Console.WriteLine("List of Violations and their Merit Deductions:");
            foreach (var violation in violations)
            {
                Console.WriteLine($"{violation.Key}: -{violation.Value} merit points");
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
        }

        // Method to display the employee's current merit score
        public void DisplayMerit()
        {
            Console.WriteLine("Workplace Merit: ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Employee ID: {EmpID}, Current Merit: {Merit}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
        }
    }
}
