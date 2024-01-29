using System.Collections;
using System.Collections.Immutable;

namespace CollectionExpression_App.CodeElement;

public class Collection
{
    private static readonly string[] s = [];
    private static readonly List<string> l = new();

    //private ImmutableArray<string> list =
    //[
    //    ..l, ..s, string.Empty, ..new string[] { }, ..new[] { "dhf", "fg" },
    //    ..new List<string> { "de", "ewewef" }.Select(x => x.ToUpper()).Where(c => c.EndsWith('f')),
    //    .. ((string[]) [.. s])[1..]
    //];
    

    public void Test(short t1, MyClass myClass)
    {
        ImmutableArray<string> list =
        [
            ..s, string.Empty, ..new string[] { }, ..new[] { "dhf", "fg" },
            ..new List<string> { "de", "ewewef" }.Select(x => x.ToUpper()).Where(c => c.EndsWith('f')),
            .. ((string[]) [.. s])[1..]
        ];
        var foo = new[] { new List<string> { "" }.Where(x => x.EndsWith('d')) };
        var l = new List<string> { "de", "ewewef"}.Select(x => x.ToUpper()).Where(c => c.EndsWith('f'));
        MyCollection element = [];
        MyCollection collection = [new MyClass(), ..element[1..3], element[0], ..new MyCollection(), ..new MyClass[5], new MyClass
            {
                Name = null,
                List = ["dfdf", ..l, ..new[]{"dsf", "sdf"}, string.Empty, ToString()!, ..(string[])["dsf", "sdf"]]
            }
        ];
        List<string> list3 = [myClass.Name, ..myClass.List, myClass.List.FirstOrDefault(), myClass.ToString() ?? string.Empty];
        List<string> list4 = new() { myClass.Name, myClass.List.FirstOrDefault(), };
        List<MyCollection> list2 = new List<MyCollection>() { new MyCollection()};
    }
}

public class Test
{
    public void Test1(MyClass myClass)
    {
        List<string> list3 = [myClass.Name, .. myClass.List, myClass.List.FirstOrDefault(),];
        List<string> list4 = new() { myClass.Name, myClass.List.FirstOrDefault(), };
    }
}

public class MyCollection : IEnumerable<MyClass>
{
    public IEnumerator<MyClass> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(MyClass myClass)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<MyClass> this[Range range]
    {
        get { throw new NotImplementedException(); }
    }
    public MyClass this[int range]
    {
        get { throw new NotImplementedException(); }
    }
}

public class MyClass
{
    public string Name { get; set; }
    public List<string> List { get; set; }

}