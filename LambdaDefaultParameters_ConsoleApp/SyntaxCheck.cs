using System.Runtime.InteropServices;

namespace LambdaDefaultParameters_ConsoleApp;

public class SyntaxCheck
{
    private const int MyConst = 1;

    public delegate bool Delegate1(bool b = false);

    public delegate bool Delegate2(bool b = true);

    public delegate bool Delegate3(bool b);

    public void Test(bool boolParameter, List<int> list)
    {
        // declaration
        Delegate1 lambda1 = (bool b = true) => b || boolParameter;
        Delegate2 lambda3 = (bool b = true) => b || boolParameter;
        Delegate3 lambda4 = (bool b = true) => b || boolParameter;

        // usages
        lambda1();
        lambda1();
        lambda1(true);

        var d = lambda1;

        // in list
        list.Where((int x = 2) => x == 1);

        var lambda2 = (int x = 2) => x == 1;

        var asyncLambda = async (string name, int x = MyConst) => await MyAsync(x);
        asyncLambda("");
        asyncLambda("", 1);
        asyncLambda("", 2);

        Action<int> action = (int i = 0) => { };

        var action1 = (params int[] myParams) => { };

        action1();
        var ints = new[] { 1, 2, 3 };
        action1(ints);
        action1(1);


        var s = MethodWithParams;

        var lambda5 = ([Optional][DefaultParameterValue(1)] int t /*= 1*/) => { };
        var lambda6 = ([My] int t = 1) => { };

        lambda6();
        lambda6(arg: 2);
    }

    void MethodWithParams(params int[] myParams)
    {
    }

    private async Task<int> MyAsync(int x)
    {
        return 1;
    }
}

public class MyAttribute : Attribute
{
}