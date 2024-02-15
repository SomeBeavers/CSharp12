using System.Collections;
using System.Runtime.CompilerServices;

namespace CollectionExpression_App.Play;

public class Class1
{
	
}

class A(List<int> s)
{
}

class B(List<int> s)
{
	public void Test()
	{
		new A([
			1,
			2,
			3]);

		var a = new A([1, 2, 3]);
	}
}

[CollectionBuilder(typeof(A1), "Create")]
public struct A1<T> : IEnumerable<int>
{
	public IEnumerator<int> GetEnumerator()
	{
		throw new NotImplementedException();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

public static class A1
{
	public static A1<T>? Create<T>(ReadOnlySpan<T> items)
	{
		return null!;
	}
}

public class MyAttribute : Attribute
{
	public MyAttribute(IEnumerable a)
	{
	}
}

[CollectionBuilder(typeof(MyCollectionBuilder), nameof(MyCollectionBuilder.Create))]
class MyCollection
{
}
class MyCollectionBuilder
{
	public static MyCollection Create(ReadOnlySpan<long>   items) => throw null;
	public static MyCollection Create(ReadOnlySpan<string> items) => throw null;
}

static class Ext
{
	public static IEnumerator<long> GetEnumerator(this MyCollection x) => throw null;
}

class Program11
{
	static void Main()
	{
		foreach (var l in new MyCollection())
		{
			long s = l;
		}

		//MyCollection x1 = [3, 2];
		MyCollection x2 = new MyCollection();
		List<int> x3 = new List<int>();
	}
}
