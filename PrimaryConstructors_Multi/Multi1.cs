namespace PrimaryConstructors_Multi;

#if NET7_0
public class Multi1
{
	public string? name;

	public Multi1(string empty)
	{
		throw new NotImplementedException();
	}
}
#else
public class Multi1(string name)
{
	public string? name = name;
}
#endif

public class UseMulti1
{
	public void Test()
	{
		var multi1 = new Multi1("");
		Console.WriteLine(multi1.name);
	}
}
