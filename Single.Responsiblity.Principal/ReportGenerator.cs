using Single.Responsiblity.Principal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single.Responsiblity.Principal
{
    // ReportGenerator class (responsibility: generating reports)
    public class ReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            if (employee.ReportFormat == "PDF")
            {
                //Job location
                //Manager
                //Employee Band
                //Salary
                // Generate PDF report
                Console.WriteLine("Generating PDF report for " + employee.Name);
            }
            else if (employee.ReportFormat == "Excel")
            {
                // Generate Excel report
                Console.WriteLine("Generating Excel report for " + employee.Name);
            }
            else if (employee.ReportFormat == "Word")
            {
                // Generate Excel report
                Console.WriteLine("Generating Excel report for " + employee.Name);
            }
        }
    }
}
