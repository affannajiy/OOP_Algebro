//Contributor: Affan
using EmpAppManagement;
using HRManagement;

namespace HRManagement
{
    public class KPI : Employee
    {
        // Properties for KPI components
        public double Performance { get; set; } // Performance rating (0 to 3)
        public double Ethics { get; set; } // Ethics rating (0 to 50)
        public int Attendance { get; set; } // Attendance rating (0 to 30)

        // Weightings for each component
        private const double PerformanceWeight = 30; // 30% weight
        private const double EthicsWeight = 20; // 20% weight
        private const double AttendanceWeight = 50; // 50% weight

        // Constructor
        public KPI(int empID, double performance, double ethics, int attendance)
            : base(string.Empty, empID, string.Empty, "", string.Empty)
        {
            Performance = performance;
            Ethics = ethics;
            Attendance = attendance;
        }

        // Method to calculate KPI components and total score
        public (double performanceScore, double ethicsScore, double attendanceScore, double kpiScore) CalculateKPI()
        {
            // Correctly scale and weight each component
            double performanceScore = (Performance / 3) * PerformanceWeight; // Scale performance (0 to 3) to 30%
            double ethicsScore = (Ethics / 50) * EthicsWeight; // Scale ethics (0 to 50) to 20%
            double attendanceScore = ((double)Attendance / 30) * AttendanceWeight; // Scale attendance (0 to 30) to 50%

            // Calculate the overall KPI score by summing the weighted components
            double kpiScore = performanceScore + ethicsScore + attendanceScore;

            // Return the component scores and the total KPI score
            return (performanceScore, ethicsScore, attendanceScore, kpiScore);
        }

        // Method to display KPI details
        public void DisplayKPI()
        {
            // Getting the calculated KPI components and total score from CalculateKPI()
            var (performanceScore, ethicsScore, attendanceScore, kpiScore) = CalculateKPI();

            // Displaying the KPI details
            Console.WriteLine("Key Performance Indicator (KPI): ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Performance Score (Weighted): {performanceScore:F2}%");
            Console.WriteLine($"Ethics Score (Weighted): {ethicsScore:F2}%");
            Console.WriteLine($"Attendance Score (Weighted): {attendanceScore:F2}%");
            Console.WriteLine($"Overall KPI Score: {kpiScore:F2}%");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
        }
    }
}