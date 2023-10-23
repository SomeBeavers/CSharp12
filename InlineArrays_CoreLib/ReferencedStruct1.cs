using System.Runtime.CompilerServices;

namespace InlineArrays_CoreLib;

[InlineArray(Count)]
public struct ReferencedStruct1
{
	private const int Count = 10;

	public int Item;
}