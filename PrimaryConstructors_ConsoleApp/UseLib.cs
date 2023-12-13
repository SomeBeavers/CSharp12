using PrimaryConstructors_Lib;

namespace PrimaryConstructors_ConsoleApp;

public class UseLib(string name) : Lib1(name, 1);

public class UseLib2(string useLibName)
{
	public void Test(string name)
	{
		var lib1 = new Lib1(name,1);
		Lib1 useLib = new UseLib(name);

		useLibName = useLib.Name;

		Console.WriteLine(useLibName);
	}
}