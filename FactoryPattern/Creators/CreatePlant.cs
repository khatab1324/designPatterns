using DesignPatterns.FactoryPattern.Interfaces;

class CraetePlant
{
    int userLevel;
    public CraetePlant()
    {
        Random random = new Random();
        userLevel = random.Next(1, 4);
    }
    public IPlant Create()
    {
        switch (userLevel)
        {
            case 1:
                return new Eearth();
            case 2:
                return new Moon();
            case 3:
                return new Mars();
            case 4:
                return new Son();
            default:
                throw new Exception("Invalid level");
        }
    }
}