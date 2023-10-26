namespace InlineArrays_Core;

public class Errors
{
	public ErrorsStruct field;

	public Errors(ErrorsStruct field)
	{
		this.field = field;
		Console.WriteLine(field[0]);
	}

	public void Test(ErrorsStruct es, int[] arr)
	{
		//switch (es)
		//{
		//	case [_, .., 1]:
		//		break;
		//}

		ReadOnlySpan<int> s = es[1..2];
		byte b = es;
	}

	//Expression<Func<ErrorsStruct, bool>> lambda = num => num[0] < 5;
}

[InlineArray(10)]
public struct ErrorsStruct(int t)
{
	private int _t;

	//public int[] Slice(int start, int length)
	//{
	//	var slice = new int[length];

	//	return slice;
	//}
	public static implicit operator byte(ErrorsStruct d)
	{
		return default;
	}

	public static explicit operator ErrorsStruct(byte b)
	{
		return new ErrorsStruct(b);
	}
}

public struct ErrorsStruct1(int t)
{
	private int _t = t;
}