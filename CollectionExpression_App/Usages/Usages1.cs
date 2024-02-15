namespace CollectionExpression_App.Usages;

public class Usages1
{
    /// <summary>
    /// This is a beaver
    /// </summary>
    private static Beaver _beaver = new Beaver
    {
        Name = "Bucky",
        Age = 2,
        Descriptions = ["cute", "fluffy"]
    };

    private static IList<Beaver> _beavers =
    [
        new Beaver { Name = "Bucky", Age = 2, Descriptions = ["cute", "fluffy"] },
        new Beaver
        {
            Name = "Jane Doe",
            Age = 1,
            Descriptions = [null]
        },
        _beaver,
        new Beaver { Name = "Bucky", Age = 2, Descriptions = ["cute", "fluffy"] },
    ];

    private static readonly List<string> list = [];

    public void Test(params int[] parameter )
    {
        var addWithDefault = (int[] addTo = null) => addTo;
        addWithDefault(); // 3
    }

    public void UseTest()
    {
        Test([1,2,3]);
        Test(1, 2, 3);
    }

}

public class Beaver
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Descriptions { get; set; }
}