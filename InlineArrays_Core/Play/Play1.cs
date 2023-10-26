using System.Runtime.CompilerServices;

namespace Issue;

[InlineArray(6)]
public struct MacAddress
{
	private byte _b;

	public void Print()
	{
		foreach (var b in this)
		{
			Console.WriteLine(b.ToString("X2"));
		}
	}
}