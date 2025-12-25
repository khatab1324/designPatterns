class Chocolate : Beverage
{
    Beverage _beverage;
    public Chocolate(Beverage beverage)
    {
        _beverage = beverage;
    }
    public override int cost()
    {
        return _beverage.cost() + 2;
    }
}