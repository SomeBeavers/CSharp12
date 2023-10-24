namespace InlineArrays_Core;

public class Arrays
{
	public void Test(ArraysStruct arraysStruct)
	{
		ArraysStruct.InnerStruct innerStruct = arraysStruct[0][1];
		var length = innerStruct[1..2].Length;
	}
}

[InlineArray(5)]
public record struct ArraysStruct
{
	private const int Length = 10;

	InnerStruct[] innerStructs;


	[InlineArray(Length)]
	internal struct InnerStruct
	{
		public int t;
	}
}