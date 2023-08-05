namespace StrategyPattern.Strategy
{
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(int amount)
        {
            Console.WriteLine($"Processing PayPal payment for amount: {amount}");
        }
    }
}
