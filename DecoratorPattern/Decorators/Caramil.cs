class Caramil : Beverage
{
    Beverage _beverage;
    public Caramil(Beverage beverage)
    {
        _beverage = beverage;
    }
    public override int cost()
    {
        return _beverage.cost() + 1;
    }
}