namespace LambdaDefaultParameters_ConsoleApp;

public class QF
{
    public void Test()
    {
        var addWithDefault = (int addTo = 1) => addTo + 1;
        addWithDefault = addTo => addTo + 3;

        addWithDefault();


        LocalFunction(1);

        void LocalFunction(int t)
        {
        }
    }

    public void Test2(InnerRecord? innerRecord = null)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        var (name, age) = innerRecord;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        var action = (InnerRecord? record = null) =>
        {
        };

        action(null);

        var addWithDefault = AddWithDefaultMethod;
        addWithDefault();
        addWithDefault(Convert.ToInt32("5"));

        var counter = CountMethod;
        counter();
        counter(1, 2);
    }

    int AddWithDefaultMethod(int addTo = 2)
    {
        return addTo + 1;
    }
    int CountMethod(params int[] xs)
    {
        return xs.Length;
    }

    public record InnerRecord(string Name, int Age)
    {
    }
}