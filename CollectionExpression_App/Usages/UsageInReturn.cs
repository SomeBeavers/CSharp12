namespace CollectionExpression_App.Usages;

public class UsageInReturn
{
    public List<int> Test()
    {
        var foo = ((List<int>) [1, 2, 3])[1..2];
        return ((List<int>)[1, 2, 3])[1..2];
    }
}