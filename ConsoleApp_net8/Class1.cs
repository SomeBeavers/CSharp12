using System.Runtime.CompilerServices;
using ConsoleApp_net8;


namespace ConsoleApp_net8;
using X = List<A?>;
using unsafe Y = int*;
file class A
{
}

public unsafe class Class1
{
    public delegate string GetNameDelegate(string name = "Jane Doe");

    public Y testField;

    public Class1(Y testField)
    {
	    this.testField = testField;
    }

    public Class1()
    {
        
    }

    public string GetName(GetNameDelegate myDelegate)
    {
	    var enumerable = new X().Where(x => x == null);
	    new X();

	    return myDelegate();
    }
    public string GetName2(Delegate myDelegate)
    {
        return (string)myDelegate.DynamicInvoke();
    }
}