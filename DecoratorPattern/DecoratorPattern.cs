static class DecoratorPattern
{
    public static void execut()
    {
        var lateh = new Caramil(new Espresso());
        var mocka = new Chocolate(new Caramil(new Espresso()));
        var weardOrder = new Milk(new Amarican());
        System.Console.WriteLine("lateh :" + lateh.cost());
        System.Console.WriteLine("mocka :" + mocka.cost());
        System.Console.WriteLine("wearOrder :" + weardOrder.cost());
        System.Console.WriteLine("wearOrder :" + weardOrder.cost());

    }
}