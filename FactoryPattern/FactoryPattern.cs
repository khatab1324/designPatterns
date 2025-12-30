static class FactoryPattern
{
    public static void execut()
    {
        var plant1 = new CraetePlant().Create();
        var plant2 = new CraetePlant().Create();
        var plant3 = new CraetePlant().Create();
        plant1.PlantDesc();
        plant1.RenderPlant();
        plant2.PlantDesc();
        plant2.RenderPlant();
        plant3.PlantDesc();
        plant3.RenderPlant();
    }
}