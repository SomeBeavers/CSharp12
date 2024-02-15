using System.Collections;

namespace CollectionExpression_App.Play;

public class Play1
{
    public void Test()
    {
        var widget = new Widget();
        widget.Children.Add(1);
        widget.Children.Add(2);
        widget.Children.Add(3);
        var widget2 = new Widget
        {
            Children =
            [
                1,
                2,
                3
            ]
        };

        int[] i = [0, .. new[] { 1, 2, 3 }, 4];
        int[] i2 = [0, .. new MyCollection2 { 1, 2, 3 }, 4];
        List<int> i3 = [0, .. (List<int>)[1, 2, 3], 4];
    }
}

public class MyCollection2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(int i)
    {
        throw new NotImplementedException();
    }
}

public class Widget
{
    public List<int> Children { get; set; }
}