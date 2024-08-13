using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Inversion.Principle
{
    public interface IPaymentGateway
    {
        void ChargeCard();
    }
}
