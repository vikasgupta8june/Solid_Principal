using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Inversion.Principle
{
    public class PaymentProcessor
    {
        private readonly IPaymentGateway _gateway;

        public PaymentProcessor(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public void ProcessPayment()
        {
            _gateway.ChargeCard();
        }
    }

}
