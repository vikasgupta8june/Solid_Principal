using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Inversion.Principle.Violate
{
    public class PaymentProcessor
    {
        private readonly StripePaymentGateway _gateway;

        public PaymentProcessor(StripePaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public void ProcessPayment()
        {
            _gateway.ChargeCard();
        }
    }
}
