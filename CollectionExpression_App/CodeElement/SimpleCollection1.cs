using CollectionExpression_App.Play;
using System.Collections;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace CollectionExpression_App.CodeElement;

public class SimpleCollection1
{
	public List<InnerClass> list = [new InnerClass { p = 1, e = 2 }, new InnerClass { p = 3, e = 4 }];

	public void Test(params InnerClass[] parameters)
	{
	}

	public void UseTest()
	{
		IList<object> foo = new List<object>();
		foo.Add("");
		foo = new List<object>();
		//List<object> foo3 = new List<object> { };

		int[] foo2 = { 1, 2, 3 };
		int[] foo3 = [1, 2, 3];
		//int[,] foo4 = [(int[])[(int)1, (int)2]];
		int[,] foo7 = { };
		int[] foo8 = { };
		//int[,] foo5 = [1];
		//int[][] foo6 = [[1, 2], [3, 4]];


		Test([new InnerClass { p = 1, e = 2 }, new InnerClass { p = 3, e = 4 }]);
        int length = ((InnerClass[]) [new InnerClass(), new InnerClass { e = 1, p = 3 }]).Length;

        List<int> list = [this.list.Count, length, foo2.Length, this.list.Capacity];
        IList<int> list2 = [length, list.Count];
		list2.Add(this.list.Capacity);
        int collection = ((UserCollection<int>) [1, ..list, list.Count])[1];
        var c = new UserCollection<int>() { };
        UserCollection<int> collection2 = [1, ..list, list.Count];
        int t = collection2.Length;
		collection2.Add(5);
        ClassWithAttrImpl tClassWithAttr = [true];
        ClassWithAttrImpl2 tClassWithAttr2 = [true, false];
        ClassWithAttr tAttr = tClassWithAttr;
        //tAttr = [..tClassWithAttr, ..tClassWithAttr2];
        tAttr = tClassWithAttr2;
        ImmutableArray<bool> tmp = [];
        foreach (bool b in tClassWithAttr)
        {
            tmp = [..tmp, b];
        }
    }
}

public class Testt
{
    public void Test()
    {
        //ClassWithAttr tClassWithAttr = [true];
    }
}



public class InnerClass
{
	public int e;
	public int p;
}

[CollectionBuilder(typeof(Builder), nameof(Builder.Create))]
public abstract class ClassWithAttr 
{
    
}

[CollectionBuilder(typeof(Builder3), nameof(Builder3.Create))]
public class ClassWithAttrImpl2 : ClassWithAttr
{
}

[CollectionBuilder(typeof(Builder2), nameof(Builder2.Create))]
public class ClassWithAttrImpl : ClassWithAttr
{
}

public class Builder
{
    //public static ClassWithAttr Create(List<bool>   items) => throw null;
    //public static ClassWithAttr Create(ReadOnlySpan<string> items) => throw null;
    //public static ClassWithAttr Create(ReadOnlySpan<long> items) => throw null;
    //public static ClassWithAttr Create(ReadOnlySpan<bool> items)
    //{
    //    throw null;
    //}

    public static ClassWithAttr Create(ReadOnlySpan<bool> items)
    {
        throw new NotImplementedException();
    }
}

public class Builder2
{
    public static ClassWithAttrImpl Create(ReadOnlySpan<bool> items)
    {
        throw new NotImplementedException();
    }

}

public class Builder3
{
    public static ClassWithAttrImpl2 Create(ReadOnlySpan<bool> items)
    {
        throw new NotImplementedException();
    }

}
static class Ext
{
    //public static IEnumerator<long> GetEnumerator(this ClassWithAttr x) => throw null;
    public static IEnumerator<bool> GetEnumerator(this ClassWithAttr x) => throw null;
}

public class UserCollection<T> : IEnumerable<T>
{
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T listCount)
    {
        throw new NotImplementedException();
    }

    public int Length { get; set; }

    public T this[int i]
    {
        get { throw new NotImplementedException(); }
    }
}
