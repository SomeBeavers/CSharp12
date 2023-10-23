namespace InlineArrays_Core;

public class Initialization
{
	public void Test(List<int> list)
	{
		// 1
		InnerStruct innerStruct = new InnerStruct();
		innerStruct[0] = 1;
		innerStruct[1] = 2;

		// 2
		InnerStruct innerStruct2 = new InnerStruct();
		for (var i = 0; i < 2; i++)
		{
			innerStruct2[i] = i;
			Console.WriteLine(innerStruct2[i]);
		}

		// 3 - error
		//InnerStruct innerStruct3 = [1,2];

		// 4 - error
		//InnerStruct innerStruct4 = new InnerStruct
		//{
		//	[0] = 1,
		//	[1] = 2
		//};
	}

	[System.Runtime.CompilerServices.InlineArray(2)]
	private struct InnerStruct
	{
		public int T;
	}
}