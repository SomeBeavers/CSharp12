namespace LambdaDefaultParameters_ConsoleApp;

public class Generic<T> where T : class, new()
{
    public delegate void D<T>(T t = default);

    public void Test<U>() where U:class, T, new()
    {
        var action = (T? i = null, int age = 1) => { Console.WriteLine(i);};
        var action2 = (T? i, int age) => { Console.WriteLine(i);};

        action(new T());
        action();

        var lambda1 = (T t = default) => { };
        var lambda2 = (U  t = null!) => { };

        var foo = (int  i = 1) => { };
        var foo1 = (int i = 1) => { };
        var list = new[] { foo, foo1 };


        
      

        M((T o = default!) => { });
    }

    // ReSharper disable once UnusedParameter.Local
    void M(D<T> p) { }

}