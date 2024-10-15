using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsManagement
{
    public class Benefit
    {
        public double PaidLeave { get; set; }
        public double Bonus { get; set; }
    }

    public Benefit(double paidLeave, double bonus)
    {
        PaidLeave = paidLeave;
        Bonus = bonus; 
    }

    public void DisplayBenefitInfo()
    {
        Console.WriteLine($"PaidLeaave Amount: {PaidLeave}");
        Console.WriteLine($"Bonus: {Bonus}";
        Console.WriteLine("-------------------------------");
    }
}
