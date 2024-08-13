using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Inversion.Principle.Violate
{
    public class StripePaymentGateway
    {
        public void ChargeCard()
        {
            Console.WriteLine("Charging card via Stripe");
        }
    }
}
