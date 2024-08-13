using Open.Closed.Principle.Interface;
using Open.Closed.Principle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Closed.Principle
{
    public class ExcelReportGenerator : IReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            // Generate Excel report
            Console.WriteLine("Generating Excel report for " + employee.Name);
        }
    }
}
