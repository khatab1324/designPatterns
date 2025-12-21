class TabletDisply : IObserver
{
    private WeatherSatation _Satation;
    public TabletDisply(WeatherSatation satation)
    {
        _Satation = satation;

    }
    public void Update()
    {
        System.Console.Write("from Tablet ");

        _Satation.getTemp();
    }

}