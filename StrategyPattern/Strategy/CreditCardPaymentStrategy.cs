namespace StrategyPattern.Strategy
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(int amount)
        {
            Console.WriteLine($"Processing Credit Card payment for amount: {amount}");
        }
    }
}
