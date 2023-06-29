namespace LambdaDefaultParameters_ConsoleApp;

public class Rider
{
    private const Int32 MyConst = 1;

    public void Test()
    {
        var lambda1 = (int t = MyConst, params int[] myParams) => { };
    }
}