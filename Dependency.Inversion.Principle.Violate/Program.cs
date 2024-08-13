namespace Dependency.Inversion.Principle.Violate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paymentProcessor = new PaymentProcessor(new StripePaymentGateway());
            paymentProcessor.ProcessPayment();
        }
    }
}
