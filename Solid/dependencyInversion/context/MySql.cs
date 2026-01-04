
public class Mysql : ISqlDatabase
{
    string host = null!;
    string? RootName = null;
    public Mysql(string rootName, string localhost)
    {
        AssignVariables(rootName, localhost);
    }
    List<User> _UserFromMysql;
    public void Connect()
    {
        try
        {
            _UserFromMysql = new List<User>();
            System.Console.WriteLine("mysql database connnected");

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            throw;
        }
    }
    public void Add(User user)
    {
        try
        {

            _UserFromMysql.Add(user);
            System.Console.WriteLine("user added to fake database");
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }

    }
    public void AssignVariables(string rootName, string localhost)
    {
        try
        {
            if (String.IsNullOrEmpty(localhost)) throw new Exception("database host is not found");
            Console.WriteLine("mysql assign variable");
            if (!String.IsNullOrEmpty(RootName)) RootName = rootName;
            host = localhost;

        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
            throw;
        }
    }
}