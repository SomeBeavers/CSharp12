namespace Issue;

public class Play2(Play2Struct play2Struct)
{
	public void Test()
	{
		var i1 = play2Struct[0];

		var arr = new Play2Struct();

		for (int i = 0; i < 10; i++)
		{
			arr[i] = i;
		}

		foreach (var item in arr)
		{
			Console.WriteLine(item);
		}

		//arr.Where(x => x > 0).Select(x => x * 2).ToArray();

	}
}

[InlineArray(6)]
public struct Play2Struct
{
	private int _element;
}