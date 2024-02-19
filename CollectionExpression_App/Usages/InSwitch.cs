namespace CollectionExpression_App.Usages;

public class InSwitch
{
    public void Test()
    {
        switch ((List<int>) [1, 2, 3, 4, 5])
        {
            case [1, 2, 3]:
                Console.WriteLine("1,2,3");
                break;
            case [1, 2, 3, 4, 5]:
                Console.WriteLine("1,2,3,4,5");
                break;
            default:
                Console.WriteLine("default");
                break;
        }

        var s = (int[]) [] switch
        {
            [.., 1] => [],
            //[1] => [1],
            [1, 2] => (int[])[1, 2, 3, 4, 5],
            _ => throw new NotImplementedException()
        };

        ((List<int>)[1, 2, 3]).Add(s switch
        {
            [1, 2, 3, 4, 5] => 1,
            _ => 2
        });


    }
}