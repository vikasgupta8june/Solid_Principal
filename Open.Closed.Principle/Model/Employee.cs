using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Closed.Principle.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal HourlyWage { get; set; }
        public int HoursWorked { get; set; }
        public string ReportFormat { get; set; }
        public string EmailAddress { get; set; }
    }
}
