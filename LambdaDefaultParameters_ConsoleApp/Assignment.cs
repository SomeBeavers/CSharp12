namespace LambdaDefaultParameters_ConsoleApp;

public class Assignment
{
    public const string Name = "test string";

    public delegate int Delegate1(string name, int age);
    public delegate int Delegate2(string name = Name, int age = 18);
    public delegate void Delegate3(int i = 0);
    public delegate void Delegate4(int[] i);
    public delegate void Delegate5(params int[] i);

    public void Test()
    {
        Delegate1 lambda1 = (string _ = "test string", int age = 1) => age;

        lambda1("", 18);

        Delegate2 lambda2 = (string _ = "test string", int age = 1) => age;

        lambda2();
        lambda2("");
        lambda2("", 1);

        Func<string, int, int> lambda3 = (string _ = "test string", int age = 1) => age;

        lambda3("",1);

        Action<string, int> lambda4 = (string _ = "test string", int _ = 1) => { };

        lambda4("",1);

        Delegate3 d1 = i => { };

        d1();
        d1(1);

        Delegate3 d2 = (int i = 0) => { };

        d2();
        d2(1);


        Delegate4 lambda5 = (params int[] ints) => { };
        Delegate5 lambda6 = (int[] ints) => { };
        Delegate5 lambda13 = (params int[] ints) => { };

        // assign lambda to lambda

        var lambda7 = (int t = 1) => { };
        var lambda8 = (int c = 1) => { };
        var lambda9 = (int d) => { };

        lambda7 = lambda8;

        var lambda10 = (int[] x) => { };
        var lambda11 = (params int[] x) => { };

        //lambda10 = lambda11;

        void LocalFunc(int i = 10)
        {
        }

        lambda7 = LocalFunc;
        lambda9 = LocalFunc;

        lambda7();
        lambda7(10);

        lambda9(1);



        int C(int[] xs)
        {
            return xs.Length;
        }

        int D(params int[] xs)
        {
            return xs.Length;
        }



        var a = (int[] xs) => xs.Length;
        // internal delegate int a'(int[] xs);
        var b = (params int[] xs) => xs.Length;
        // internal delegate int b'(params int[] xs);

        var c = C;
        // internal delegate int a'(int[] xs);
        var d = D;
        // internal delegate int b'(params int[] xs);

        //a = b; // Not allowed
        a = c; // Allowed
        //b = c; // Not allowed
        b = d; // Allowed

        c = (params int[] xs) => xs.Length; 
        d = (int[] xs) => xs.Length;

        c = (int[] xs) => xs.Length;

        c = (params int[] xs) => xs.Length;

        c = (int[] xs) => xs.Length;
    }

    public void Test2()
    {
        int E(int j = 13)
        {
            return 11;
        }

        int F(int k = 0)
        {
            return 3;
        }

        int G(int x = 13)
        {
            return 4;
        }

        var a = (int i = 13) => 1;
        // internal delegate int b'(int arg = 13);
        var b = (int i = 0) => 2;
        // internal delegate int c'(int arg = 0);
        var c = (int i = 13) => 3;
        // internal delegate int b'(int arg = 13);
        var d = (int c = 13) => 1;
        // internal delegate int b'(int arg = 13);

        var e = E;
        // internal delegate int b'(int arg = 13);
        var f = F;
        // internal delegate int c'(int arg = 0);
        var g = G;
        // internal delegate int b'(int arg = 13);

        //a = b; // Not allowed
        a = c; // Allowed
        a = d; // Allowed
        c = e; // Allowed
        //e = f; // Not Allowed
        b = f; // Allowed
        e = g; // Allowed

        d = (int c = 10) => 2; // Error: default parameter value is different between new lambda
        // and synthesized delegate b'. We won't do implicit conversion
    }

    delegate int Del(int a = 1);

    public void Test3()
    {
        // This would be a compilation error
        Del del = (int x = 100) => x;
    }

    public void Test4()
    {
        var d = (int x = 10) => x;
        // Then
        d = (int y = 20) => y;
        d();
    }

    public void Test5()
    {
        int Identity(int x = 100) => x;

        Del del = Identity;

        var x = del();

        Console.WriteLine(x);

    }

    public void Test6()
    {
        Del del = (int x = 100) => x;

        var x = del();

        Console.WriteLine(x);
    }

    delegate void M(int i = 42);

    public static void Target(int i) => Console.WriteLine(i);

    public void Test7()
    {
        M local = Target;
        dynamic d = local;
        d();
    }
}