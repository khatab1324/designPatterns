static public class SingletonPattern
{
    public static void execute()
    {
        var db = DataBaseManger.getInstance();
        db.SaveData();
        var db2 = DataBaseManger.getInstance();
        db2.SaveData();
        var db3 = DataBaseManger.getInstance();
        db3.SaveData();
    }
}