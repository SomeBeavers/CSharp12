namespace CollectionExpression_App.CodeElement;

public class Element1
{
	public const string S = "6";

	private const string V = "1";
	private static readonly UserDefinedType UserDefinedType;
	private static readonly UserDefinedType UserDefinedType2;

	static Element1()
	{
		UserDefinedType = new UserDefinedType();
	}

	public void Test(UserDefinedTypeBase userDefinedBase, UserDefinedType2 userDefinedType2, object objectParameter)
	{
		// TODO: Simple element int
		int[] simpleElement1 = [1];
		int[] simpleElement2 = [1, 2, 3, 4, 5, 6];

		// TODO: const
		List<string> const1 = ["1", "2", "3", "4", "5", S, V, OtherClass.S];

		// TODO: user defined type
		Span<UserDefinedTypeBase> userDefinedList =
			[(UserDefinedTypeBase)userDefinedType2, UserDefinedType, userDefinedBase];
		UserDefinedTypeBase[] userDefinedList2 =
		[
			..userDefinedList[1..2], /*..const1,*/ userDefinedBase, /*..null,*/
			..new[] { new UserDefinedType() }, ..new List<UserDefinedTypeBase>(), ..new UserDefinedTypeBase[] { }
		];
		UserDefinedType[] userDefinedList4 = [];
		var userDefinedList3 = userDefinedList2;
		

		// TODO: collection

		var foo = new []{ new List<string> { "" }.Where(x => x.Length == 1) };
		string[] s = [.. new List<string> { "" }.Where(x => x.Length == 1)];
	}

}

internal class MyClassS
{
	public const string S = "6";
	public const int IntField = 6;

	public void Test()
	{
		var strings = Array.Empty<string>();
		bool[] s2 = [];
		bool[] s = [true, false, true, false, ..new bool[] { }, .. Array.Empty<bool>(), ..s2];
		//
	}
}

public class UserDefinedTypeBase
{
	public static explicit operator UserDefinedTypeBase(UserDefinedType2 v)
	{
		throw new NotImplementedException();
	}
}

public class UserDefinedType : UserDefinedTypeBase
{
	public string Name { get; set; }
}

public class UserDefinedType2
{
	public string Name { get; set; }
}

public static class OtherClass
{
	public const string S = "6";
}