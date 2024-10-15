using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitManagement
{
    public class BenefitList
    {
        public List<Benefit> benefits;
    }

    public BenefitList()
    {
        benefits = new List<Benefit>();
    }

    public void AddBenefit(Benefit benefit)
    {
        benefits.Add(benefit);
    }

    public void RemoveBenefit(Benefit benefit)
    {
        benefits.Remove(benefit);
    }

    public void DisplayAllBenefits()
    {
        Console.WriteLine("Benefits List:");
        Console.WriteLine("-------------------------------");
        foreach (Benefit benefit in benefits)
        {
            benefit.DisplayBenefitInfo();
        }
    }
}
