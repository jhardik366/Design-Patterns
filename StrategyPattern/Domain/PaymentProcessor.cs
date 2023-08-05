using StrategyPattern.Strategy;

namespace StrategyPattern.Domain
{
    public class PaymentProcessor
    {
        IPaymentStrategy _paymentStrategy;

        // constructor injection
        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(int amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
