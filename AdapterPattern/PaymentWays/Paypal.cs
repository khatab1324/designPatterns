using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern.PaymentWays;

public class Paypal : IPaypal
{
    public void PaypalPay()
    {
        System.Console.WriteLine("initial pay for paypal");
    }
}