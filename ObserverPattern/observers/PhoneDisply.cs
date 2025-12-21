class PhoneDisply : IObserver
{
    private WeatherSatation _Satation;
    public PhoneDisply(WeatherSatation satation)
    {
        _Satation = satation;

    }
    public void Update()
    {
        System.Console.Write("from Phone");
        _Satation.getTemp();
    }

}