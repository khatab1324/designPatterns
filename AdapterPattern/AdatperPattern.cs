using DesignPatterns.AdapterPattern.Interfaces;
using DesignPatterns.AdapterPattern.PaymentWays;

public class AdapterPattern
{
    public static void excute()
    {
        IStrip strip = new PaymentProcessAdapter(new PaymentProcess(200, "khattab"));
        IPaypal paypal = new PaymentProcessAdapter(new PaymentProcess(150, "samer"));
        strip.StripPay();
        paypal.PaypalPay();
    }
}