using designPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern.PaymentWays;

public class PaymentProcess:IPaymentProcess
{
    int Charge;
    string Username;
    public PaymentProcess(int charge, string username)
    {
        Charge = charge;
        Username = username;
    }
    public void excutePayment()
    {
        System.Console.WriteLine($"user:{Username}, chage {Charge} ");
    }
}