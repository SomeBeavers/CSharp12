namespace LambdaDefaultParameters_Lib;

public class Lib1
{
    public Func<int, int> GetLambda()
    {
        return (int t = 1) => t;
    }
}