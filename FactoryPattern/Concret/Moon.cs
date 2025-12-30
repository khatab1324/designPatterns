using DesignPatterns.FactoryPattern.Interfaces;

class Moon : IPlant
{
    public void PlantDesc()
    {
        Console.WriteLine("This is a Moon Plant");
    }

    public void RenderPlant()
    {
        Console.WriteLine("Rendering Moon Plant...");
    }
}