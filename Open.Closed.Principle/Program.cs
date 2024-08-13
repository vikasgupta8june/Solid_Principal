using Open.Closed.Principle.Interface;
using Open.Closed.Principle.Model;

namespace Open.Closed.Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Name = "John Doe" };

            IReportGenerator pdfReportGenerator = new PdfReportGenerator();
            pdfReportGenerator.GenerateReport(employee);

            IReportGenerator excelReportGenerator = new ExcelReportGenerator();
            excelReportGenerator.GenerateReport(employee);
        }
    }
}
