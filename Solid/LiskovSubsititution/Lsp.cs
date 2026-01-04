namespace oopWithCsharp.Solid
{
    public class Lsp
    {
        public Lsp()
        {
            Bird bird1 = new Penguin();
            Bird bird2 = new Koktail();

            MakeBirdLeave(bird1);
            MakeBirdLeave(bird2);
            

            FlyBird flying1 = new FlyBird();
            FlyBird flying2 = new Koktail();
            MakeItFly(flying1);
            MakeItFly(flying2);
        }
        static void MakeBirdLeave(Bird bird)
        {
            bird.Leaving();
        }

        static void MakeItFly(FlyBird bird)
        {
            bird.Fly();
        }
    }

}