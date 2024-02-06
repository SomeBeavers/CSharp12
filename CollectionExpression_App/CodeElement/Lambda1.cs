namespace CollectionExpression_App.CodeElement;

public interface IMyUserType
{
	List<string> Phones { get; set; }
}

public class MyUserType : IMyUserType
{
	public MyUserType()
	{
	}

	public MyUserType(string name, int age, List<string> phones)
	{
		Name = name;
		Age = age;
		Phones = phones;
	}

	public string Name { get; set; }

	public int Age { get; set; }

	public List<string> Phones { get; set; }
}
public class MyUserType2 : IMyUserType
{
	public MyUserType2()
	{
	}

	public MyUserType2(string name, int age, List<string> phones)
	{
		Name = name;
		Age = age;
		Phones = phones;
	}

	public string Name { get; set; }

	public int Age { get; set; }

	public List<string> Phones { get; set; }
}

public static class GetUsers
{
	public static List<MyUserType> Get(int[] array)
	{
		return new()
		{
			new() { Name = "Name1", Age = 1, Phones = ["123", "456"] },
			new MyUserType() { Name = "Name2", Age = 2, Phones = ["789", "012"] }
		};
	}
}

class UseMyUserType
{
	public void Test()
	{
		MyUserType[] myUserTypes =
		[
			new() { Name = "Name1", Age = 1, Phones = ["123", "456"] },
			new MyUserType() { Name = "Name2", Age = 2, Phones = ["789", "012"] }
		];

		MyUserType[] myUserTypes3 =
		{
			new() { Name = "Name1", Age = 1, Phones = ["123", "456"] },
			new MyUserType() { Name = "Name2", Age = 2, Phones = ["789", "012"] }
		};

		MyUserType[] myUserTypes2 = new MyUserType[]
		{
			new() { Name = "Name1", Age = 1, Phones = ["123", "456"] },
			new MyUserType() { Name = "Name2", Age = 2, Phones = ["789", "012"] }
		};
	}
}

public class Lambda1
{
	private readonly int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

	public void Test(A a, B b)
	{
		int[] x = [arr.FirstOrDefault(x => x > 1), .. arr.Select(x => x)];
		List<Func<string, A>> y = [_ => a, _ => a, /*caret*/Func,];
		List<Func<string, A>> y2 = [_ => a, _ => a, /*caret*/Func, .. y[1..2]];
	}

	public void Test2(int x, int y, bool b_parameter, int[] array)
	{
		List<int> l = [x, y, .. b_parameter ? [1, 2, 3] : (int[])[], .. (int[])[]];
		//((int[])[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]).ForEach(l, x => Console.WriteLine(x));

		Span<bool?> s = [false, true, null, b_parameter == true, b_parameter == true];

		ReadOnlySpan<bool> methodCalls =
			[MethodReturnBool(), (bool)MethodReturnNullableBool()!, .. MethodReturnBoolArray()];
		MyUserType[] myUserTypes =
		[
			new() { Name = "Name1", Age = 1, Phones = ["123", "456"] },
			new MyUserType() { Name = "Name2", Age = 2, Phones = ["789", "012"] }
		];

		MyUserType[] myUserTypes3 =
		{
			new() { Name = "Name1", Age = 1, Phones = ["123", "456"] },
			new MyUserType() { Name = "Name2", Age = 2, Phones = ["789", "012"] }
		};

		MyUserType[] myUserTypes2 = new MyUserType[]
			{
			new() { Name = "Name1", Age = 1, Phones = ["123", "456"] },
			new MyUserType() { Name = "Name2", Age = 2, Phones = ["789", "012"] }
		};

		int[] ints = [1,2,3,4];
		IMyUserType[] myUserTypes4 =
		[
			new MyUserType(name: "Jane Doe", age: 18, phones: ["911", "112"]),
			.. myUserTypes2,
			GetUsers.Get(ints)[1],
			.. GetUsers.Get([1,2,34, .. arr, ..ints])[1..2]
		];

		List<IMyUserType> lonelyUser = [
			new MyUserType(name: "Jane Doe", age: 18, phones: ["911", "112"]),
			new MyUserType2(name: "Jane Doe", age: 18, phones: ["911", "112"]),
		//..myUserTypes2,
		//GetUsers.Get(ints)[1],
		//..GetUsers.Get([1, 2, 34, .. arr, .. ints])[1..2]
			];

		List< IMyUserType > myList =  new()
		{
			new MyUserType(name: "Jane Doe", age: 18, phones: ["911", "112"]),
			new MyUserType2(name: "Jane Doe", age: 18, phones: ["911", "112"])
		};

	}

	private bool MethodReturnBool()
	{
		throw new NotImplementedException();
	}

	private bool[] MethodReturnBoolArray()
	{
		throw new NotImplementedException();
	}

	private bool? MethodReturnNullableBool()
	{
		throw new NotImplementedException();
	}


	private A Func(string arg)
	{
		throw new NotImplementedException();
	}
}

public class A
{
}

public class B /* : A*/
{
}