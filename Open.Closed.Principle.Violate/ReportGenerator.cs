using Open.Closed.Principle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Closed.Principle
{
    public class ReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            // Generate PDF report
            Console.WriteLine("Generating PDF report for " + employee.Name);
        }
    }

    //Now, let's say we want to add a new feature to generate reports in Excel format.
    //Without OCP, we might modify the existing ReportGenerator class:

    //public class ReportGenerator
    //{
    //    public void GenerateReport(Employee employee, string format)
    //    {
    //        if (format == "PDF")
    //        {
    //            // Generate PDF report
    //            Console.WriteLine("Generating PDF report for " + employee.Name);
    //        }
    //        else if (format == "Excel")
    //        {
    //            // Generate Excel report
    //            Console.WriteLine("Generating Excel report for " + employee.Name);
    //        }
    //    }
    //}

}
