using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Inversion.Principle 
{
    public class StripePaymentGateway : IPaymentGateway
    {
        public void ChargeCard()
        {
            Console.WriteLine("Charging card via Stripe");
        }
    }

}
