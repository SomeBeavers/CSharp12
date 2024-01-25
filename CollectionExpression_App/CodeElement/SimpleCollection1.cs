namespace CollectionExpression_App.CodeElement;

public class SimpleCollection1
{
	public List<InnerClass> list = [new InnerClass { p = 1, e = 2 }, new InnerClass { p = 3, e = 4 }];

	public void Test(params InnerClass[] parameters)
	{
	}

	public void UseTest()
	{
		IList<object> foo = new List<object>();
		foo.Add("");
		foo = new List<object>();
		//List<object> foo3 = new List<object> { };

		int[] foo2 = { 1, 2, 3 };
		int[] foo3 = [1, 2, 3];
		//int[,] foo4 = [(int[])[(int)1, (int)2]];
		int[,] foo7 = { };
		int[] foo8 = { };
		//int[,] foo5 = [1];
		//int[][] foo6 = [[1, 2], [3, 4]];


		Test([new InnerClass { p = 1, e = 2 }, new InnerClass { p = 3, e = 4 }]);
	}
}



public class InnerClass
{
	public int e;
	public int p;
}