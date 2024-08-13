using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Segregation.Principle.Violates
{
    public interface Printer
    {
        void PrintDocument();
        void PrintPhoto();
        void Fax();
    }
}
