using Liskov.Substitution.Principle.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.Substitution.Principle.Child
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new Exception("Penguins can't fly");
        }
    }
}
