using designPatterns.AdapterPattern.Interfaces;
using DesignPatterns.AdapterPattern.Interfaces;

public class PaymentProcessAdapter : IStrip, IPaypal
{
    IPaymentProcess _PaymentProcess;
    public PaymentProcessAdapter(IPaymentProcess paymentProcess)
    {
        _PaymentProcess = paymentProcess;
    }
    public void StripPay()
    {
        _PaymentProcess.excutePayment();
    }
    public void PaypalPay()
    {
        _PaymentProcess.excutePayment();

    }
}