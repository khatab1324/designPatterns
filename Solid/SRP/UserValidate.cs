namespace oopWithCsharp.Solid;

public class UserValidate
{
    public static bool validate(Person person)
    {
        if (string.IsNullOrWhiteSpace(person.firstName))
        {
            System.Console.WriteLine("you didn't add the first name bro");
            Mesaeges.endApplicationMessage();
            return false;
        }
        if (string.IsNullOrWhiteSpace(person.lastName))
        {
            System.Console.WriteLine("you didn't add the last name bro");
            Mesaeges.endApplicationMessage();

            return false;
        }
        if (string.IsNullOrWhiteSpace(person.phone))
        {
            System.Console.WriteLine("you didn't add the phone bro");
            Mesaeges.endApplicationMessage();

            return false;
        }
        return true;
    }
}
