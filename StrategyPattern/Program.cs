using StrategyPattern.Domain;
using StrategyPattern.Strategy;

class Program
{
    public static void Main()
    {
        PaymentProcessor paymentProcessor = new PaymentProcessor(new CreditCardPaymentStrategy());
        paymentProcessor.ProcessPayment(50);

        paymentProcessor.SetPaymentStrategy(new BitcoinPaymentStategy());
        paymentProcessor.ProcessPayment(100);

        paymentProcessor.SetPaymentStrategy(new PayPalPaymentStrategy());
        paymentProcessor.ProcessPayment(200);
    }
}