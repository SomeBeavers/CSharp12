using LambdaDefaultParameters_Lib;

namespace LambdaDefaultParameters_ConsoleApp;

public class Refactorings<T> where T : struct
{
    public delegate T MyDelegate(T renamed);

    public void Test<U>(T t, List<T> list)
    {
        MyDelegate lambda4 = (T renamed = default) =>
        {
            Console.WriteLine(renamed);

            return renamed;
        };

        list.ForEach((T renamed = default) => { Console.WriteLine(renamed); });
        const int t1 = 1;

        var lambda1 = (int          thisIsALambdaParameterWithLongName     = t1,
                       string       nameThisIsALambdaParameterWithLongName = "this is a name parameter",
                       string       name                                   = "this is a name parameter",
                       params int[] thisIsJustParams) =>
        {
        };
        var lambda2 = (int thisIsALambdaParameter, string name, int thisIsAnotherParameter,
                       int thisIsYesAnotherParameter) =>
        {
        };

        void Lambda1(int          thisIsALambdaParameterWithLongName     = t1,
                     string       namethisIsALambdaParameterWithLongName = "this is a name parameter",
                     string       name                                   = "",
                     params int[] thisIsJustParams)
        {
        }

        new Lib1().GetLambda();
    }
}