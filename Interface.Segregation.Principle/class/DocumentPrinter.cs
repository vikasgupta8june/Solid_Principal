using Interface.Segregation.Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Segregation.Principle
{
    public class DocumentPrinter : IDocumentPrinter
    {
        public void PrintDocument()
        {
            Console.WriteLine("Printing document");
        }
    }

}
