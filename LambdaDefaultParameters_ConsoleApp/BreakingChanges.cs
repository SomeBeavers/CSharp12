namespace LambdaDefaultParameters_ConsoleApp;

public class BreakingChanges
{
    public void Test()
    {
        void M1(int i = 1) { }
        var m1 = M1; // Infers Action<int>
        m1(); // error CS7036: There is no argument given that corresponds to the required parameter 'obj' of 'Action<int>'

        void M2(params int[] xs) { }
        var m2 = M2; // Infers Action<int[]>
        m2(); // error CS7036: There is no argument given that corresponds to the required parameter 'obj' of 'Action<int[]>'
    }
}