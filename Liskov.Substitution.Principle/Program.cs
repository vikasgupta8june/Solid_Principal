using Liskov.Substitution.Principle.Base;
using Liskov.Substitution.Principle.Child;

namespace Liskov.Substitution.Principle
{
    //The LSP states that any code that uses a base type should be able to work
    //with a subtype without knowing the difference.

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
