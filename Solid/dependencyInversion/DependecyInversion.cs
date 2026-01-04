public class DependencyInversion
{
    public void execute()
    {
        var userRepoMysql = new UserRepo<ISqlDatabase>(new Mysql("root", "172.1.1.1"));
        var userRepoList = new UserRepo<IDatabase>(new DatabaseList());

        userRepoMysql.Save(new User(1, "khattab", 18));
        userRepoList.Save(new User(2, "khalid", 20));

    }
}