namespace InlineArrays_Core;

public class Usage<T, U> where T : struct where U : class
{
	public void Test(UsageStruct<TypeStruct> usageStruct, U t, DynamicStruct ds, byte b)
	{
		//var typeStruct = usageStruct[ref t];
		//var typeStruct2 = usageStruct[out t];
		//var typeStruct3 = usageStruct[""];
		var typeStruct4 = usageStruct[(int)1.2];
		//var typeStruct5 = usageStruct[(int)1.2,2];
		var typeStruct6 = usageStruct[^1];
		ReadOnlySpan<TypeStruct> typeStruct7 = usageStruct[2..^3];
		Span<TypeStruct> typeStruct8 = usageStruct[2..^3];
		TypeStruct typeStruct9 = usageStruct[b];

		typeStruct7 = typeStruct8;

		typeStruct7 = typeStruct7[2..^3];

		dynamic myDynamic = ds[0];

		var o = typeStruct7[myDynamic];

		var o1 = usageStruct[1];
		//var o2 = usageStruct[in t];

		ref var o3 = ref usageStruct[1];
		ref readonly var o4 = ref usageStruct[0];


	}
}

[InlineArray(10)]
public struct UsageStruct<T> where T : struct
{
	public T T1;
	//public T this[string i] => this[i.Length];
}

[InlineArray(5)]
public struct TypeStruct
{
	public string Name { get; set; }
}

[InlineArray(10)]
public struct DynamicStruct
{
	private dynamic _dynamicField;
}