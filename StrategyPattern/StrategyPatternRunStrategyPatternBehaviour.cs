static class StaregyPattern
{
    public static void excute()
    {
        Duck duck = new Duck(new JetFly(), new HugQuack(), new GraphicDisplay());
        duck.Display();
        duck.Fly();
        duck.Quack();

        Duck duck2 = new Duck(new SimpleFly(), new SimpleQuack(), new ConsoleDisplay());
        duck2.Display();
        duck2.Fly();
        duck2.Quack();  

        Duck duck3 = new Duck(new NoFly(), new NoQauck(), new ConsoleDisplay());;
        duck3.Display();        
        duck3.Fly();
        duck3.Quack();
    }
}