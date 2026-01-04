public class UserRepo<T> where T : IDatabase
{
    private readonly T _db;

    public UserRepo(T db)
    {
        _db = db;
    }

    public void Save(User user)
    {
        _db.Connect();
        _db.Add(user);
    }

    public T GetDatabase() => _db;
}