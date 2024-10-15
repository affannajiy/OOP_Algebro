using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibraries;

namespace OOP_Algebro_HR_Management_Website
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            ApplicantList applicantList = new ApplicantList();

            EmployeeList employeeList = new EmployeeList();

            FeedbackList feedbackList = new FeedbackList();

            KPI kPI = new KPI();

            LeaveRequest leaveRequest = new LeaveRequest();

            TimeTrackingList timeTrackingList = new TimeTrackingList();

            //Class Library Part
            //Reference: https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-8-0
            int row = 0;

            do
            {
                if (row == 0 || row >= 25)
                    ResetConsole();

                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                Console.WriteLine($"Input: {input}");
                Console.WriteLine("Begins with uppercase? " +
                     $"{(input.StartsWithUpper() ? "Yes" : "No")}");
                Console.WriteLine();
                row += 4;
            } while (true);
            return;

            // Declare a ResetConsole local method
            void ResetConsole()
            {
                if (row > 0)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
                row = 3;
            }
        }
    }
}