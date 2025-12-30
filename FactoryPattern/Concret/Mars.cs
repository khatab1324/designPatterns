using DesignPatterns.FactoryPattern.Interfaces;

class Mars : IPlant
{
    public void PlantDesc()
    {
        Console.WriteLine("Mars Plant: A hardy plant that thrives in arid conditions.");
    }

    public void RenderPlant()
    {
        Console.WriteLine("Rendering Mars Plant with red hues and spiky leaves.");
    }
}