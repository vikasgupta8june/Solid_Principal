using Liskov.Substitution.Principle.Base;
using Liskov.Substitution.Principle.Child;

namespace Liskov.Substitution.Principle.Violate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BirdBehavior birdBehavior = new BirdBehavior();
            Bird duck = new Duck();
            Bird penguin = new Penguin();

            birdBehavior.MakeBirdFly(duck); // Output: Duck is flying
            birdBehavior.MakeBirdFly(penguin); // Output: Penguins can't fly
        }
    }
}
