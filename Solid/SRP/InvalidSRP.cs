// namespace oopWithCsharp.Solid;
public class CreateUserInfoInvalide
{
    string? firstName;
    string? lastName;
    public CreateUserInfoInvalide()
    {

        System.Console.WriteLine("welcome to generate username app");
        System.Console.WriteLine("what is your frist name");
        firstName = Console.ReadLine();
        System.Console.WriteLine("what is your last name");
        lastName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstName))
        {
            System.Console.WriteLine("you didn't add the first name bro");
            System.Console.ReadLine();
            return;
        }
        if (string.IsNullOrWhiteSpace(lastName))
        {
            System.Console.WriteLine("you didn't add the last name bro");
            System.Console.ReadLine();
            return;
        }
        System.Console.WriteLine($"Your username is :{firstName.Substring(0, 1)}{lastName}");
        System.Console.ReadLine();
    }
}