public static class ObserverPattern
{
    static public void excute()
    {
        var satation = new WeatherSatation();
        var tvDisply = new TvDisply(satation);
        var phoneDisply = new PhoneDisply(satation);
        var tabletDisply = new TabletDisply(satation);
        satation.Add(tvDisply);
        satation.Add(tabletDisply);
        satation.Add(phoneDisply);
        satation.setTemp(45);
        System.Console.WriteLine("");
        satation.setTemp(50);
        System.Console.WriteLine("");
        satation.setTemp(35);
        System.Console.WriteLine("");
        satation.setTemp(25);
    }
}