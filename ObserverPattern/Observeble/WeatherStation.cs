
class WeatherSatation : IObserveble
{
    private int temp = 40;
    private List<IObserver> _ObserversList = new List<IObserver>();

    public void Add(IObserver observer)
    {
        _ObserversList.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        _ObserversList.Remove(observer);
    }
    public void Notify()
    {
        _ObserversList.ForEach(e => e.Update());
    }
    public void getTemp()
    {
        Console.WriteLine($"current temp is : {temp} ");
    }
    public void setTemp(int newTemp)
    {
        temp = newTemp;
        Notify();
    }

}