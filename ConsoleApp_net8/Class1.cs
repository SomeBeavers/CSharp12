namespace ConsoleApp_net8;

public class Class1
{
    public delegate string GetNameDelegate(string name = "Jane Doe");

    public string GetName(GetNameDelegate myDelegate)
    {
        return myDelegate();
    }
    public string GetName2(Delegate myDelegate)
    {
        return (string)myDelegate.DynamicInvoke();
    }
}