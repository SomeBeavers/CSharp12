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