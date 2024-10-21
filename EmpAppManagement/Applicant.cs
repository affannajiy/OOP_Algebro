﻿namespace EmpAppManagement
{
    public class Applicant
    {
        public string AppName { get; set; }
        public string AppContactNum { get; set; }
        public string AppRole { get; set; }
        public DateTime IvDate { get; set; }

        // Constructors
        public Applicant(string appName, string appContactNum, string appRole, DateTime ivDate)
        {
            AppName = appName;
            AppContactNum = appContactNum;
            AppRole = appRole;
            IvDate = ivDate;
        }

        // Display
        public void DisplayApplicantInfo()
        {
            Console.WriteLine($"Applicant Name: {AppName}");
            Console.WriteLine($"Contact Number: {AppContactNum}");
            Console.WriteLine($"Role: {AppRole}");
            Console.WriteLine($"Interview Date: {IvDate.ToString("dd/MM/yyyy HH:mm")}");
            Console.WriteLine("-------------------------------");
        }
    }
}