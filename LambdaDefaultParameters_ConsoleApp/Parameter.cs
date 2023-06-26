namespace LambdaDefaultParameters_ConsoleApp;

public class Parameter<T> where T : new()
{
    public delegate int? Delegate1(T? t = default);

    public delegate int? Delegate4(int? t = 1);

    public delegate int? Delegate5(int? t);

    private const string MyConst = "VALUE";

    public void Test1()
    {
        Delegate1 lambda1 = (T? t = default) => t?.GetHashCode();
        var lambda2 = (T? t = default) => t?.GetHashCode();
        Func<T?, int?> lambda3 = (T? t = default) => t?.GetHashCode();

        Delegate4 lambda4 = (int? t = 2) => t;
        Delegate5 lambda5 = (int? t = 2) => t;

        Delegate4 lambda6 = t => t;

        Delegate4 method1 = LocalFunction;
        Delegate5 method2 = LocalFunction;

        lambda1();
        lambda1(new T());

        lambda2();
        lambda2(new T());

        //lambda3();
        lambda3(new T());

        lambda4();
        lambda4();
        lambda4(2);

        lambda6();

        lambda6();

        method1();

        method1();

        int? LocalFunction(int? t = 0)
        {
            return 1;
        }
    }

    public void Test2()
    {
        var lambda1 = (int x = 1) => x;
        var lambda2 = ((string Name, InnerType) tuple = default) => tuple.Name;

        lambda2();

        var lambda3 = (List<string>? list = null) => list?.FirstOrDefault();

        lambda3();
        lambda3(new List<string> { "", "string" });
        lambda3();

        var lambda4 = (IInnerType parameter = null) => parameter.MethodFromInterface();

        var lambda5 = (double s_renamed = 1) => s_renamed;

        string? l;
        var lambda6 = (string s = nameof(l)) => Console.WriteLine(s);
        var lambda7 = (string s = $"""
                                   this is a string
                                   which is multiline
                                   {MyConst}
                                   """)
            => Console.WriteLine(s);
        l = "";

        //var lambda8 = (T method = MyLocalFunc) => { };

        //var lambda9 = (ref int t = 1) => { };
        var lambda10 = (in int t = 1) => { };
        //var lambda11 = (out int t = 1) => { };
        //var lambda12 = (this int x = 1) => { };

        const int t21 = 3;
        int t3 = 4;

        var lambda11 = static (int t = 1) =>
        {
            return t + t21;
        };

        var lambda12 = (int t = t21) => t + t21 + t3;

        var lambda13 = (bool b, string name, params int[] ages) =>
        {
        };

        T MyLocalFunc(int t = t21)
        {
            throw new NotImplementedException();
        }
    }
}

public interface IInnerType
{
    void MethodFromInterface();
}

public class InnerType : IInnerType
{
    public void MethodFromInterface()
    {
        throw new NotImplementedException();
    }
}