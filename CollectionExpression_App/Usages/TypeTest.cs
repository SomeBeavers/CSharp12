using System.Collections.Immutable;

namespace CollectionExpression_App.Usages;

public class TypeTest
{
    public void Test()
    {
        var a = AsArray([1, 2, 3]);          // AsArray<int>(int[])
        var b = AsListOfArray([[4, 5], []]); // AsListOfArray<int>(List<int[]>)

        static T[] AsArray<T>(T[]                   arg) => arg;
        static List<T[]> AsListOfArray<T>(List<T[]> arg) => arg;


        var x = ((int[])[1]).AsImmutableArray();
        var y = ((List<int>)[2]).AsImmutableArray();
        var z = Extensions.AsImmutableArray([1,2,3]);
        ((int[])[1,2,3]).AsImmutableArray();
    }

    public void Test2()
    {
        var enumerable = new MyGeneric<int>().Test([new{Name = ""}]);
    }
}

public class MyGeneric<U>
{
    public IEnumerable<T> Test<T>(params T[] parameters) 
    {
        foreach (var t in parameters)
        {
            yield return t;
        }
    }
}

static class Extensions
{
    public static ImmutableArray<T> AsImmutableArray<T>(this IEnumerable<T> arg) => (ImmutableArray<T>)arg;
}