using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LambdaDefaultParameters_Framework;

public class Usage
{
    public delegate void MyDelegate(string s = "", params int[] parameters);
    public void Test()
    {
        var lambda1 = (string s = "", params int[] parameters) => { };
        var action = (string s = "", params int[] parameters) => { };

        MethodWithLambda((string s = "", params int[] parameters) => { });
        MethodWithLambda2(lambda1);

        var s = "my string";

        var lambda2 = (string myLambdaStringParameter = "", params int[] _) =>
            Console.WriteLine(myLambdaStringParameter);
        lambda2();
        lambda2("test string", 1, 2, 3);
    }

    public async Task<int> TestAsync(int i, A a)
    {
        var lambda1 = async (string name, int t = default, params A[] parameters) =>
        {
            foreach (var parameter in parameters) Console.WriteLine(parameter);

            return await Task.FromResult(i + t);
        };
        await lambda1("");
        await lambda1("", 1);
        await lambda1("", 1, new A(), a);
        await lambda1("", 1, a, new A());
        await lambda1("", 1, new A(), new A());

        void LocalFunction(string name, int t = default, params A[] parameters)
        {
            foreach (var parameter in parameters) Console.WriteLine(parameter);
        }

        LocalFunction("");

        MyDelegate dl;

        return await Task.FromResult(1);
    }

    delegate int Del(int a = 1);

    public void Test2()
    {
        var a = (int i = 13) => 1;
        // internal delegate int <>F{00000002}(int arg0 = 13);
        var b = (int i = 0) => 2;
        // internal delegate int <>F{00000003}(int arg0 = 0);
        var c = (int i = 13) => 3;
        // internal delegate int <>F{00000002}(int arg0 = 13);
        var d = (int c = 13) => 1;
        // internal delegate int <>F{00000002}(int arg0 = 13);
        //a = b; // Not allowed
        a = c; // Allowed
        a = d; // Allowed

        var d2 = (int x = 10) => x;
        // Not allowed because default parameter value in lambda does not match the default
        // value reflected under the hood in the natural type for `d` generated above
        d2 = (int y = 20) => y;


        // Not allowed because default parameter value in Delegate type does not match
        Del del = (int x = 100) => x;
    }

    public class A
    {
    }

    private void MethodWithLambda2(MulticastDelegate lambda1)
    {
        throw new NotImplementedException();
    }

    private void MethodWithLambda(Action<string, int[]> action)
    {
        throw new NotImplementedException();
    }
}

