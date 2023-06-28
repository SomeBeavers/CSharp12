using System.ComponentModel;
using System.Runtime.InteropServices;

namespace LambdaDefaultParameters_ConsoleApp;

public class Errors
{
    public delegate string MyDelegate(string s = "", params int[] parameters);
    public delegate double MyDelegate2(double s = 1, params int[] parameters);

    public void Test1()
    {
        var lambda1 = (string s = "test", params int[] p) => s;
        lambda1();
        UseLambda12((string s = "test", params int[] p) => s);

        const double localVar = 1;
        var lambda2 = (double i = localVar + 2, params int[] p) => i;
        MyDelegate2 lambda3 = delegate(double i, int[] p) { return i; };

        lambda3();

        //var lambda4 = ([Optional][DefaultParameterValue("")]string s = "test", params int[] p) => s;
    }
    delegate int DelegateNoDefault(int x);
    delegate int DelegateWithDefault(int x = 1);

    delegate int DelegateNoParams(int[] xs);
    delegate int DelegateWithParams(params int[] xs);

    public void Test2()
    {

        int MethodNoDefault(int x) => x;
        int MethodWithDefault(int x = 2) => x;
        DelegateNoDefault d1 = MethodWithDefault; // no warning: source is a method group
        DelegateWithDefault d2 = MethodWithDefault; // no warning: source is a method group
        DelegateWithDefault d3 = MethodNoDefault; // no warning: source is a method group
        DelegateNoDefault d4 = (int x = 1) => x; // warning: source present, target missing
        DelegateWithDefault d5 = (int x = 2) => x; // warning: source present, target different
        DelegateWithDefault d6 = (int x) => x; // no warning: source missing, target present


        int MethodNoParams(int[] xs) => xs.Length;
        int MethodWithParams(params int[] xs) => xs.Length;
        DelegateNoParams d7 = MethodWithParams; // no warning: source is a method group
        DelegateWithParams d8 = MethodNoParams; // no warning: source is a method group
        DelegateNoParams d9 = (params int[] xs) => xs.Length; // warning: source present, target missing
        DelegateWithParams d10 = (int[] xs) => xs.Length; // no warning: source missing, target present
    }

    public void ParamsTest()
    {
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

        c = (params int[] xs) => xs.Length; // Error: different delegate types; no implicit conversion
        d = (int[] xs) => xs.Length; // Error: different delegate types; no implicit conversion
    }

    public void Test3()
    {
        var d = (int c = 13) => 1;
        d = (int c = 10) => 2; // Error: default parameter value is different between new lambda
        // internal delegate int b'(int arg = 13);
    }


    private void UseLambda12(MyDelegate func)
    {
        throw new NotImplementedException();
    }

    private void UseLambda1(MulticastDelegate lambda1)
    {
        lambda1.DynamicInvoke("");
    }
}

public static class MyStaticClass
{
    public static void Test()
    {
        
    }
}