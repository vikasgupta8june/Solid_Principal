using Interface.Segregation.Principle.Violates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Segregation.Principle.Violates
{
    public class DocumentPrinter : Printer
    {
        public void PrintDocument()
        {
            Console.WriteLine("Printing document");
        }

        public void PrintPhoto()
        {
            throw new NotImplementedException();
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }
    }

}
