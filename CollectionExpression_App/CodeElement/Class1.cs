using System.Collections;
using System.Runtime.CompilerServices;

namespace CollectionExpression_App.CodeElement4;

[CollectionBuilder(typeof(BuilderGen), nameof(BuilderGen.Create))]
public class Generic1<T> : IEnumerable<T>
{
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Add(T s)
    {
        throw new NotImplementedException();
    }
}

public class TestGen<T>
{
    public void Method()
    {
        Generic1<string> generic1 = ["f", String.Empty];
        Generic1<string> generic3 = new Generic1<string>() {"f", String.Empty };
        Generic1<T> generic2 = [];
        List<int> list = [];
    }

}

public class BuilderGen
{
    public static Generic1<T> Create<T>(ReadOnlySpan<T> items)
    {
        throw new NotImplementedException();
    }

    public static Generic1<T> Create<T>(ReadOnlySpan<object> items)
    {
        throw new NotImplementedException();
    }
}

public static class ExtGen
{
    public static IEnumerator<T> GetEnumerator<T>(this Generic1<T> x) => throw null;
}
