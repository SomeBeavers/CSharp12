using System.Runtime.InteropServices;

namespace InlineArrays_Core;

[StructLayout(LayoutKind.Auto)]
[InlineArray(Length)]
public record struct MyStruct(int Age)
{
	private const int Length = 10;
	public static string T = "test";


	public int this[string s]
	{
		get => this[s];
		set => this[s] = value;
	}
	//public string Name { get; set; } = T;
}