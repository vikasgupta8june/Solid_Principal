using Liskov.Substitution.Principle.Base;
using Liskov.Substitution.Principle.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.Substitution.Principle
{
    public class BirdBehavior
    {
        public void MakeBirdFly(Bird bird)
        {
            bird.Fly();
        }

        //public void MakeBirdFly(Bird bird)
        //{
        //    if (bird is Penguin)
        //    {
        //        Console.WriteLine("Penguins can't fly");
        //    }
        //    else
        //    {
        //        bird.Fly();
        //    }
        //}
    }

}
