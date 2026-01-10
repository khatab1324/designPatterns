using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern.PaymentWays;

public class Strip : IStrip
{
    public void StripPay()
    {
        System.Console.WriteLine("initial pay for strip");
    }
}