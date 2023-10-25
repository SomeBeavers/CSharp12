namespace InlineArrays_Core;

public class ReadOnlyCheck
{
	[System.Runtime.CompilerServices.InlineArray(10)]
	public struct Buffer10<T>
	{
		private T _element0;
	}

	void M1(Buffer10<int> x)
	{
		ref int a = ref x[0]; // Ok, equivalent to `ref int a = ref InlineArrayAsSpan<Buffer10<int>, int>(ref x, 10)[0]`
	}

	void M2(in Buffer10<int> myParameter)
	{
		var i = myParameter[0];
		ref var s = ref i;
	}

	//void M2(in Buffer10<int> x)
	//{
	//	ref readonly int a = ref x[0]; // Ok, equivalent to `ref readonly int a = ref InlineArrayAsReadOnlySpan<Buffer10<int>, int>(in x, 10)[0]`
	//	//ref int b = ref x[0]; // An error, `x` is a readonly variable => `x[0]` is a readonly variable
	//}

	Buffer10<int> GetBuffer() => default;

	void M3()
	{
		int a = GetBuffer()[0]; // Ok, equivalent to `int a = InlineArrayAsReadOnlySpan<Buffer10<int>, int>(GetBuffer(), 10)[0]` 

		//ref readonly int b = ref GetBuffer()[0]; // An error, `GetBuffer()[0]` is a value
		//ref int c = ref GetBuffer()[0]; // An error, `GetBuffer()[0]` is a value
	}
}

internal class A
{
}

