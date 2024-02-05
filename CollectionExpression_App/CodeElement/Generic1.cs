namespace CollectionExpression_App.CodeElement;

public class Generic1<T> where T : struct
{
	public List<T> GetList(T parameter)
	{

		return [parameter, new T(), ];
	}
}

public class GenericBase
{
}