namespace LambdaDefaultParameters_ConsoleApp;

public class Generic<T> where T : class, new()
{
    public void Test()
    {
        var action = (T? i = null, int age = 1) => { Console.WriteLine(i);};
        var action2 = (T? i, int age) => { Console.WriteLine(i);};

        action(new T());
        action();
    }

}