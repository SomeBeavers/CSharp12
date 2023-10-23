namespace InlineArrays_Core;

public class SingleField<T> where T : new()
{
	public void Test(MyStruct2<T> myStruct2)
	{
		myStruct2[0] = new T();
		switch (myStruct2[1])
		{
			default:
				break;
		}

		
	}

	public unsafe void Test2(MyStruct3 myStruct3, RefStruct refStruct)
	{
		//int* i = myStruct3[0];

		//var i = refStruct[0];
	}
}

[InlineArray(10)]
public struct MyStruct2<T>
{
	public T? _t1 = default;
	private T? t => _t1;
	public T? t2 => t;

	public MyStruct2()
	{
	}
}


[InlineArray(10)]
public struct MyStruct3
{
	private unsafe int* t;

}

[InlineArray(10)]
public ref struct RefStruct
{
	private ref int t2;
}

[InlineArray(10)]
struct MyStruct4
{
	private int t2;
	//private int t3;
	//private int t4;
	//private int t5;
	//private int t6;
	//private int t7;
	//private int t8;
	//private int t9;
	//private int t10;
	//private int t11;
}