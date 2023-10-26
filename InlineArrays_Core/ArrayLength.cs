using System.Runtime.InteropServices;

namespace InlineArrays_Core;

public class ArrayLength
{
	public void Test(MyStruct myStruct = default)
	{
		for (var i = 0; i < 1000; i++) myStruct[""] = i;

		foreach (var name in myStruct) Console.WriteLine(name);

		var i1 = myStruct[0];
		
		foreach (var i in myStruct)
		{
			Console.WriteLine(i.ToString());
		}
	}
}

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