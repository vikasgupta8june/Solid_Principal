using Open.Closed.Principle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Closed.Principle.Model;

namespace Open.Closed.Principle
{
    public class PdfReportGenerator : IReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            // Generate PDF report
            Console.WriteLine("Generating PDF report for " + employee.Name);
        }
    }
}
