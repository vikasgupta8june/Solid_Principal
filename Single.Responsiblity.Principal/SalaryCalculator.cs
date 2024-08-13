using Single.Responsiblity.Principal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single.Responsiblity.Principal
{
    // SalaryCalculator class (responsibility: calculating salary)
    public class SalaryCalculator
    {
        public decimal CalculateSalary(Employee employee)
        {
            return employee.HourlyWage * employee.HoursWorked + 100;
        }
    }
}
