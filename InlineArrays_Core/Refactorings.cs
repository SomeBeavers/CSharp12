namespace InlineArrays_Core;

public class Refactorings
{
	public void Test(RefactoringsStruct refactoringsStruct, int[] arr)
	{
		var t = refactoringsStruct[0];
		var span = refactoringsStruct[1..2];
		var i = arr[0];
	}
}

[InlineArray(10)]
public struct RefactoringsStruct
{
	private int t;
}