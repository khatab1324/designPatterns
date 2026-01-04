namespace oopWithCsharp.Solid;

public class UserDataCapture
{

    public static Person captureData()
    {
        Person user = new();
        Mesaeges.welcomeMessage();

        Mesaeges.askForFirstName();
        user.firstName = Console.ReadLine();

        Mesaeges.askForLastName();
        user.lastName = Console.ReadLine();

        Mesaeges.askForphone();
        user.phone = Console.ReadLine();
        return user;
    }
}