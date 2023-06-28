namespace LambdaDefaultParameters_ConsoleApp;

public class SeveralParameters
{
    public delegate int Lambda1(MyRecord record, int i, string s = "myString");

    public void Test()
    {
        Lambda1 lambda1 = (MyRecord record, int i, /*caret*/string s = "") => i;

        int result = lambda1(new MyRecord(), 1);
        int result2 = lambda1(new MyRecord(), 1, "test string");
    }

    public void Test2()
    {
        var addWithDefault = AddWithDefaultMethod;
        addWithDefault(); // 3
        addWithDefault(5); // 6

        addWithDefault = (int addTo = 3) => addTo + 1;

        var counter = CountMethod;
        counter(); // 0
        counter(1, 2); // 2

        int AddWithDefaultMethod(int addTo = 2)
        {
            return addTo + 1;
        }
        int CountMethod(params int[] xs)
        {
            return xs.Length;
        }
    }
}

public record MyRecord;