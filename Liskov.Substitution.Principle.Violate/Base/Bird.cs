using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.Substitution.Principle.Base
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}
