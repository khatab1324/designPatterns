
public class DatabaseList : IDatabase
{

    List<User> _User;
    public void Connect()
    {
        try
        {
            _User = new List<User>();
            System.Console.WriteLine("list database connnected");
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
            _User.Add(user);
            System.Console.WriteLine("user added to list database");
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
            throw;
        }

    }

}