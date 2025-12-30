using DesignPatterns.FactoryPattern.Interfaces;

class Son : IPlant
{
    public void PlantDesc()
    {
        Console.WriteLine("This is Son Plant");
    }

    public void RenderPlant()
    {
        Console.WriteLine("Rendering Son Plant");
    }
}