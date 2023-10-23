using System.Runtime.CompilerServices;

namespace InlineArrays_Nuget;

[InlineArray(Item)]
public struct Nuget1
{
	private const int Item = 2;
	public string Name { get; set; }
}