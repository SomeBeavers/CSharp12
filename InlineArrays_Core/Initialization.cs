using System.Runtime.CompilerServices;

namespace InlineArrays_Core;

public class Initialization
{
	public void Test()
	{
		InnerStruct innerStruct = [1, 2];
	}

	//[InlineArray(2)]
	public struct InnerStruct
	{
		public int t;
	}
}
