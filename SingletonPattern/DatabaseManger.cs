public sealed class DataBaseManger
{
    private static DataBaseManger _instance = null;
    private int counter = 0;

    public static DataBaseManger getInstance()
    {
        if (_instance == null) _instance = new DataBaseManger();
        return _instance;
    }
    public void SaveData()
    {
        System.Console.WriteLine("saved user data" + counter);
        counter++;
    }
}