namespace CollectionExpression_App.CodeElement;

public class Element2
{
	public void Test(int parameter)
	{
		string[] s =
		[
			$$"""
			 my {{parameter}}
			 test
			 $"{parameter}".Length.ToString()
			 """,
			$"{parameter}".Length.ToString(),
			.. (string[])["","my string"]
		];


	}
}