namespace HRManagement
{
    public class Benefit
    {
        // Properties for employee details and benefits
        public int EmpID { get; private set; }
        public double KPI { get; private set; } // Employee's KPI score
        public double PaidLeave { get; private set; } // Paid leave in days
        public double Bonus { get; private set; } // Bonus amount in monetary value

        // Thresholds for benefits
        private const double HighKPIThreshold = 90; // High KPI (>80%) for maximum benefits
        private const double MediumKPIThreshold = 60; // Medium KPI (60%-80%) for some benefits

        // Constructor that accepts empID and the KPI score directly
        public Benefit(int empID, double kpiScore)
        {
            EmpID = empID;
            KPI = kpiScore;
            PaidLeave = 0; // Initialize with no paid leave
            Bonus = 0; // Initialize with no bonus
        }

        // Method to assign benefits based on the provided KPI score
        public void AssignBenefitsBasedOnKPI()
        {
            if (KPI >= HighKPIThreshold)
            {
                PaidLeave = 5; // 10 days of paid leave for high KPI
                Bonus = 1000; // $1000 bonus for high KPI
            }
            else if (KPI >= MediumKPIThreshold)
            {
                PaidLeave = 2; // 5 days of paid leave for medium KPI
                Bonus = 400; // $500 bonus for medium KPI    
            }
            else
            {
                PaidLeave = 0; // No paid leave for low KPI
                Bonus = 0; // No bonus for low KPI
            }
        }

        // Method to display the benefits assigned
        public void DisplayBenefits()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"KPI Score: {KPI:F2}%");
            Console.WriteLine($"Paid Leave: {PaidLeave} days");
            Console.WriteLine($"Bonus: ${Bonus:F2}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
