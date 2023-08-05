namespace StrategyPattern.Strategy
{
    public class BitcoinPaymentStategy : IPaymentStrategy
    {
        public void ProcessPayment(int amount)
        {
            Console.WriteLine($"Processing Bitcoin payment for amount: {amount}");
        }
    }
}
