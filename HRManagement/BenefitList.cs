//Contributor: Adham, Affan
namespace HRManagement
{
    public class BenefitList
    {
        private List<Benefit> benefitList;

        // Constructor to initialize the list
        public BenefitList()
        {
            benefitList = new List<Benefit>();
        }

        // Method to add a new Benefit for an employee
        public void AddBenefit(Benefit benefit)
        {
            benefitList.Add(benefit);
            Console.WriteLine($"Benefit added for Employee ID: {benefit.EmpID}");
        }

        // Method to remove a Benefit by employee ID
        public void RemoveBenefit(int empID)
        {
            Benefit benefit = benefitList.Find(b => b.EmpID == empID);
            if (benefit != null)
            {
                benefitList.Remove(benefit);
                Console.WriteLine($"Benefit removed for Employee ID: {empID}");
            }
            else
            {
                Console.WriteLine($"No benefit record found for Employee ID: {empID}");
            }
        }

        // Method to display all Benefit records
        public void DisplayAllBenefits()
        {
            Console.WriteLine("Employee Benefits List:");
            Console.WriteLine("-------------------------------------------");
            foreach (var benefit in benefitList)
            {
                benefit.DisplayBenefits();
            }
        }

        // Method to find and display a specific Benefit by employee ID
        public void FindBenefitByID(int empID)
        {
            Benefit benefit = benefitList.Find(b => b.EmpID == empID);
            if (benefit != null)
            {
                benefit.DisplayBenefits();
            }
            else
            {
                Console.WriteLine($"No benefit record found for Employee ID: {empID}");
            }
        }
    }
}
