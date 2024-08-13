using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single.Responsiblity.Principal
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal HourlyWage { get; set; }
        public int HoursWorked { get; set; }
        public string ReportFormat { get; set; }
        public string EmailAddress { get; set; }

        public decimal CalculateSalary()
        {
            return HourlyWage * HoursWorked;
            //return HourlyWage * HoursWorked + 50;
        }

        public void GenerateReport()
        {
            if (ReportFormat == "PDF")
            {
                // Generate PDF report
                Console.WriteLine("Generating PDF report for " + Name);
            }
            else if (ReportFormat == "Excel")
            {
                // Generate Excel report
                Console.WriteLine("Generating Excel report for " + Name);
            }
            else if (ReportFormat == "Word")
            {
                // Generate Excel report
                Console.WriteLine("Generating Excel report for " + Name);
            }

        }

        public void SendEmail()
        {
            // Send email to EmailAddress using STMP protocol
            Console.WriteLine("Sending email to " + EmailAddress);
        }
    }

}
