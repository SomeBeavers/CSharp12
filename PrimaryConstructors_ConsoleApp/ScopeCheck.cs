namespace PrimaryConstructors_ConsoleApp;

public class ScopeCheck
{
    public void UseScopeCheckClass(string parameter = "Hello")
    {
        var scopeCheck = new ScopeCheckClass(parameter);
    }
}

public class ScopeCheckClass(string firstName)
{
    public string GetName(string surname)
    {
        return $"{firstName} {surname}";
    }


    public string FirstName { get; set; } = firstName;

    public string FirstNameField = firstName;
}

public class Derived : Base
{
    private readonly bool _b;

    public Derived(int i, string s, bool b) : base(s)
    {
        this._b = b;
        this.I = i;
    }

    public int I { get; set; }
    public string B => this._b.ToString();
}

public class Base(string s);
