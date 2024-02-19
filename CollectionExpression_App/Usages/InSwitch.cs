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
            [1, 2] => (int[]) [1, 2, 3, 4, 5],
            _ => throw new NotImplementedException()
        };

        ((List<int>) [1, 2, 3]).Add(s switch
        {
            [1, 2, 3, 4, 5] => 1,
            _ => 2
        });

        var balance = 0m;
        foreach (var transaction in ReadRecords())
        {
            balance += transaction switch
            {
                [_, "DEPOSIT", _, var amount] => decimal.Parse(amount),
                [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
                [_, "INTEREST", var amount] => decimal.Parse(amount),
                [_, "FEE", var fee] => -decimal.Parse(fee),
                [..] => throw new InvalidOperationException(
                    $"Record {string.Join(", ", transaction)} is not in the expected format!"),
                _ => throw new InvalidOperationException(
                    $"Record {string.Join(", ", transaction)} is not in the expected format!")
            };
            Console.WriteLine($"Record: {string.Join(", ", transaction)}, New balance: {balance:C}");
        }

        IEnumerable<int[]> s2 = [[1], [2]];
        CalculateDiscount([1, 2, 3, 4, 5]);
    }

    private IEnumerable<string[]> ReadRecords()
    {
        IEnumerable<int> s2 = [1, 2, 3, 4, 5];
        return
        /*caret*/[
  
            ["1", "DEPOSIT", "100"],
            ["2", "WITHDRAWAL", "50"],
            ["3", "INTEREST", "5"],
            ["4", "FEE", "10"]
        ];
    }

    public decimal[] CalculateDiscount(int[] order)
    {
        return order switch
        {
            [> 10, var s, ..] => [s + 0.10m],
            [> 5, var s, ..] => [s + 0.5m],
            [> 0, var s, ..] => [s],
            null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
            var someObject => [0m]
        };
    }
}