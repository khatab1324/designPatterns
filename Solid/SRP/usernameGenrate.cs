

namespace oopWithCsharp.Solid;

public class UsernameGenrate
{
    public static void usernameGen(Person user)
    {
        System.Console.WriteLine($"Your username is :{user.firstName.Substring(0, 1)}{user.lastName}{user.phone.Substring(0, 2)}");

    }
}
