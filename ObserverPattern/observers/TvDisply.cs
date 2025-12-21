class TvDisply : IObserver
{
    private WeatherSatation _Satation;
    public TvDisply(WeatherSatation satation)
    {
        _Satation = satation;

    }
    public void Update()
    {
        System.Console.Write("from Tv ");
        _Satation.getTemp();
    }

}