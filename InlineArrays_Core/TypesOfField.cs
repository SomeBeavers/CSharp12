using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace InlineArrays_Core;

public class TypesOfField<T>
{
	public List<int>? Test(MyStruct myStruct)
	{
		return myStruct[0];
	}



	//[StructLayout(LayoutKind.Explicit)]
	[InlineArray(5)]
	public struct MyStruct
	{
		//[FieldOffset(0)] 
		private List<int>? _objectField;
	}

	//public record struct MyStruct2
	//{
	//	private object _objectField;
	//}

	//[InlineArray(5)]
	public struct MyStruct3
	{
		//public int* ObjectField;
		//public required int ObjectField;
		//public readonly int ObjectField;
	}

	[InlineArray(10)]
	public struct GenericStruct<T>
	{
		public static T? ObjectField;
		public T? field;
	}

	public T? Test2(GenericStruct<T> genericStruct)
	{
		return genericStruct[I()];
	}

	private static int I()
	{
		return 110;
	}

	[InlineArray(11)]
	public struct MyEnumStruct
	{
		GenericStruct<MyEnum>? _enumField;
	}

	public GenericStruct<MyEnum>? Test3(MyEnumStruct myEnumStruct)
	{
		return myEnumStruct[1];
	}
}