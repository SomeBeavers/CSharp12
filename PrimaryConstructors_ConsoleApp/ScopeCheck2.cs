namespace PrimaryConstructors_ConsoleApp;

public class ScopeCheck2<T>(int count)
{
    //public int Count { get; set; } = count;
    public void Test()
    {
        Func<int, int> square = x => x * count;
    }
}