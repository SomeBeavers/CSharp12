using System.Collections.Immutable;

namespace CollectionExpression_App.AssignedTo;

public class ArrayTypes
{
    public class InnerClassInArrayTypes;
    public void Test1(List<User>? listOfUsers = null)
    {
        List<int> list = [1, 2, 3];
        ImmutableArray<int> immutableArray = [1, 2, 3];
        int[] array = [1, 2, 3];
        IList<int> iList = [1, 2, 3];
        IEnumerable<int> iEnumerable = [1, 2, 3];
        ICollection<int> iCollection = [1, 2, 3];

        var listFromEnumerable = iEnumerable.ToList();

        foreach (var i in iCollection)
        {
            listFromEnumerable.Add(i);
            Console.WriteLine(i);
        }

        foreach (var i in listFromEnumerable)
        {
            Console.WriteLine(i);
        }

        IReadOnlyCollection<int> iReadOnlyCollection = [1, 2, 3];
        IReadOnlyList<int> iReadOnlyList = [1, 2, 3];
        User[] users = [new User { Name = "John", Age = 25 }, new User { Name = "Doe", Age = 30 }];
        List<User> usersList = [new User { Name = "John", Age = 25 }, new User { Name = "Doe", Age = 30 }];
        List<User> usersList2 = listOfUsers ?? [new User { Name = "John", Age = 25 }, new User { Name = "Doe", Age = 30 }];

        var user = new User { Name = "John", Age = 25 };
        var user2 = new User { Name = "Doe", Age = 30 };
        User[] usersArray = [user, user2];

        SortedList<int, int> sortedList = new()
        {
            { 1, 1 },
            { 2, 2 }
        };
        //SortedList<int, int> sortedList2 = [{1,1}, {2,2}];
        Dictionary<int, int> dictionary = new()
        {
            { 1, 1 },
            { 2, 2 }
        };

        Span<int> span = [1, 2, 3];
        ReadOnlySpan<int> readOnlySpan = [1, 2, 3];
        span = [..readOnlySpan];
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Phones { get; set; }
}