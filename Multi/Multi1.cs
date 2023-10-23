using System.Runtime.CompilerServices;

namespace Multi;

#if NET8_0_OR_GREATER
[InlineArray(1)]
#endif
internal struct Multi1
{
	private int t;
}

internal class MyClass
{
	public void Test()
	{
		var multi1 = new Multi1();

#if NET8_0_OR_GREATER
		foreach (var i in multi1)
		{
			Console.WriteLine(i);
		}
#endif
	}
}