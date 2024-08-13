using Open.Closed.Principle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Closed.Principle.Interface
{
    public interface IReportGenerator
    {
        public void GenerateReport(Employee employee);
    }
}
