
using DesignPatterns.FactoryPattern.Interfaces;

class Eearth : IPlant
{
    public void PlantDesc()
    {
        Console.WriteLine("This is Earth Plant");
    }

    public void RenderPlant()
    {
        Console.WriteLine("Rendering Earth Plant");
    }
}