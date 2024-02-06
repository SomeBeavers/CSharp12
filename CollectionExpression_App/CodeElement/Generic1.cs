using System.Collections;
using System.Runtime.CompilerServices;
using ConsoleApp_net8;

namespace CollectionExpression_App.CodeElement;

[CollectionBuilder(typeof(BuilderGen), nameof(BuilderGen.Create))]
public class Generic1<T> //where T : struct
    : IEnumerable<T>
{
    //public List<T> GetList(T parameter)
    //{

    //	return [parameter, new T(), ];
    //}
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Add(string s)
    {
        throw new NotImplementedException();
    }
}

public class TestGen<T> where T : new()
{
    public void Method(int y)
    {
        Generic1<string> generic1 = ["f", String.Empty, ..(string[])["e", "sfdsf", Testst()]];
        Generic1<string> generic2 = ["f", String.Empty, ];
       
        Generic1<T> generic3 = ["j", 1, generic1, new T()];
        List<T> list = new List<T>() {};
       // List<T> list = [new T?()];


    }

    private string Testst()
    {
        throw new NotImplementedException();
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
    public static IEnumerator<T> GetEnumerator<T>(this Generic1<T> x)  => throw null;
}

public class MyAttribute : Attribute
{
    private string v;

    public MyAttribute(string v)
    {
        this.v = v;
    }
}

public class GenericBase
{
}