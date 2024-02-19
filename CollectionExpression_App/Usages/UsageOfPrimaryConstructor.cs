namespace CollectionExpression_App.Usages;

public class UsageOfPrimaryConstructor(List<User> users, User additionalUser)
    : ClassWithPrimaryConstructor(users ?? [..users ?? [], additionalUser])
{
    public UsageOfPrimaryConstructor(string name) : this([new User { Name = name }], new User())
    {
    }

    public UsageOfPrimaryConstructor() : this([new User()], new User())
    {
    }

    public UsageOfPrimaryConstructor(User user) : this([user], new User())
    {
    }

    public UsageOfPrimaryConstructor(List<User> users) : this([
        ..users, new User
        {
            Name = "Jane Doe"
        }
    ], new User())
    {
    }
}

public class ClassWithPrimaryConstructor(IList<User> users)
{
    List<User> _users;

    public ClassWithPrimaryConstructor(List<User> users, string name) : this([users[1], users[2]]) => _users = [];
}

public class User
{
    public string Name { get; set; }
}

public class UsePrimaryConstructor
{
    public void Test(User user, List<User> users)
    {
        var usageOfPrimaryConstructor = new UsageOfPrimaryConstructor([..users, user], new User());
        var usageOfPrimaryConstructor2 = new UsageOfPrimaryConstructor(users, new User());
        var usageOfPrimaryConstructor3 = new UsageOfPrimaryConstructor([user], new User());
    }

    public void Test2()
    {
        Test(new User
        {
            Name = "null"
        }, [CallMethod()]);
    }

    private User CallMethod()
    {
        throw new NotImplementedException();
    }
}