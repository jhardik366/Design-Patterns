namespace StrategyPattern.Strategy
{
    public interface IPaymentStrategy
    {
        public void ProcessPayment(int amount);
    }
}
