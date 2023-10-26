using static InlineArrays_Core.UseMethod;

namespace InlineArrays_Core;

public class UseMethod
{

	public void GetInlineArray()
	{

	}

	public ReadOnlySpan<int> Test1(in UseMethodStruct<int> parameter)
	{
		return parameter[0..1];
	}
	public UseMethodStruct<int> Test1(UseMethodStruct<int> parameter, int t, BoolStruct boolStruct)
	{
		ReadOnlySpan<int> parameter2 = Test1(in parameter);

		var parameterTt = parameter.InlineArrayParameter;



		foreach (var a in getBufferAsValue())
		{
			Console.WriteLine(a);
		}

		//foreach (var b in getBufferAsWritableVariable())
		//{
		//	Console.WriteLine(b);
		//}

		//foreach (var c in getBufferAsReadonlyVariable())
		//{
		//	Console.WriteLine(c);
		//}

		Buffer10<int> getBufferAsValue() => default;
		//ref Buffer10<int> getBufferAsWritableVariable() => default;
		//ref readonly Buffer10<int> getBufferAsReadonlyVariable() => default;

		var i = !boolStruct[0];
		boolStruct[0] = false;
		boolStruct[1] = true;
		boolStruct[2] = false;
		boolStruct[3] = true;
		boolStruct[4] = false;
		//boolStruct[5] = true;

		//Buffer10<int> b = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]; // initializes user-defined inline array

		return parameter;
	}

	static C M2() => new C() { F = { [0] = 111 } }; // Ok, indexer is invoked

	class C
	{
		public Buffer10<int> F;
	}

	[System.Runtime.CompilerServices.InlineArray(10)]
	public struct Buffer10<T>
	{
		private T _element0;

		public T this[int i]
		{
			get => this[i];
			set => this[i] = value;
		}
	}


	[InlineArray(5)]
	public struct BoolStruct
	{
		private bool b;
	}


	[InlineArray(10)]
	public struct UseMethodStruct<T>
	{
		public T InlineArrayParameter;
		//private  T InlineArrayParameter ;
	}
}

interface IGenericInterface<T>
{
	public T GetInlineArray();
}

class ImplementIGenericInterface: IGenericInterface<UseMethodStruct<int>>
{
	public UseMethodStruct<int> GetInlineArray()
	{
		return new UseMethodStruct<int>();
	}
}