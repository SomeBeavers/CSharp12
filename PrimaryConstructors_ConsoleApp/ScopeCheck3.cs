using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace PrimaryConstructors_ConsoleApp;

public class C(bool b, int i, string s = "") : B(b), IDisposable // b passed to base constructor
{
    public int I { get; set; } = i; // i used for initialization
    public string? S // s used directly in function members
    {
        get => s;
        set => s = value ?? throw new Exception(nameof(b));
    }
    public C(string s) : this(false, 0) { } // must call this(...)
    public C() : this(false, 0) { } // must call this(...)

    public void Dispose()
    {
        // TODO release managed resources here
    }
}

public class B(bool b)
{
}


public partial class ScopeCheck3(string name, C? c = null, MyEnum @enum = MyEnum.Value1, Func<string>? funcParameter = null): BaseScopeCheck3(name)
{
    public void Test1()
    {
        name = "Hello";
        var nameName = nameof(name);
    }

    public ScopeCheck3() : this("Jane Doe")
    {
        //var name = name;
    }

    public ScopeCheck3(string name, int age) : this(name)
    {

        //var name = name;
    }
    
    public unsafe void Test2()
    {
    }

    public string GetName(string surname)
    {
        var list = new List<string>();
        list.Add(name);
        return $"{Name} {surname}";
    }

    public partial string TestPartial()
    {
        return name;
    }


    public string Name { get; } = name;

    public class Nested
    {
        public string Name { get; set; } 
    }
}

public partial class ScopeCheck3
{
    public partial string TestPartial();
}

public class BaseScopeCheck3(string name)
{
}

public class UseScopeCheck3
{
    public void Test()
    {
        var scopeCheck = new ScopeCheck3("Hello");
        Console.WriteLine(scopeCheck.Name);
    }
}