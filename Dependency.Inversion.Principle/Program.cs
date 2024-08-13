namespace Dependency.Inversion.Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paymentGateway = new StripePaymentGateway();
            var paymentProcessor = new PaymentProcessor(paymentGateway);
            paymentProcessor.ProcessPayment();
        }
    }
}
