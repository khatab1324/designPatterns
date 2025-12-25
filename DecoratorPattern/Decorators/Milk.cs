class Milk : Beverage
{
    Beverage _beverage;
   public Milk(Beverage beverage)
    {
        _beverage = beverage;
    }
    public override int cost()
    {
        return _beverage.cost() + 1;
    }
}