using Single.Responsiblity.Principal.Model;

namespace Single.Responsiblity.Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Name = "John Doe",
                HourlyWage = 20.0m,
                HoursWorked = 40,
                ReportFormat = "PDF",
                EmailAddress = "john.doe@example.com"
            };

            SalaryCalculator salaryCalculator = new SalaryCalculator();
            decimal salary = salaryCalculator.CalculateSalary(employee);
            Console.WriteLine("Salary: " + salary);

            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.GenerateReport(employee);

            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(employee);
        }
    }
}
