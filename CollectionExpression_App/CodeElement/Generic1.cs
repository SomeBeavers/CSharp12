using System.Runtime.CompilerServices;

namespace CollectionExpression_App.CodeElement;

[CollectionBuilder(typeof(BuilderGen), nameof(BuilderGen.Create))]
public class Generic1<T> where T : struct
{
	public List<T> GetList(T parameter)
	{

		return [parameter, new T(), ];
	}
}

public class BuilderGen
{
    internal static object Create()
    {
        throw new NotImplementedException();
    }
}

public static class ExtGen
{
    public static IEnumerator<T> GetEnumerator<T>(this Generic1<T> x) where T : struct => throw null;
}

public class MyAttribute : Attribute
{
    private string v;

    public MyAttribute(string v)
    {
        this.v = v;
    }
}

public class GenericBase
{
}