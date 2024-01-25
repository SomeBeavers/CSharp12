namespace CollectionExpression_App.CodeElement;

public class SimpleCollectionWithSpread
{
	public void Test(List<InnerClass2> parameterList, IList<InnerClass2> anotherCollection)
	{
		InnerClass2[] s =
		[
			..parameterList, new InnerClass2(), .. anotherCollection, .. anotherCollection, .. anotherCollection,
			.. anotherCollection, .. anotherCollection, .. anotherCollection, .. anotherCollection
		];
		InnerClass2[] s2 = [..parameterList, new InnerClass2(), ..anotherCollection];

		var innerClass2 = anotherCollection;
	}
}

public class InnerClass2
{
}