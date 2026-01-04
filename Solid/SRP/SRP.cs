namespace oopWithCsharp.Solid;
public class CreateUserInfo
{


    public CreateUserInfo()
    {
        Person user = UserDataCapture.captureData();

        bool isUserValide = UserValidate.validate(user);
        if (isUserValide)
        {
            UsernameGenrate.usernameGen(user);
            Mesaeges.endApplicationMessage();
        }
        else
        {
            new CreateUserInfo();
        }
    }
}