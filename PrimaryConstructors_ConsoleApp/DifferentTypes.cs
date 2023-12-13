namespace PrimaryConstructors_ConsoleApp;

public class DifferentTypes
{
	private class MyClass(string name);

	private readonly struct MyStruct(string name)
	{
		public string Name { get; } = name;
	}

	//private interface IMyInterface(string name);

	//private enum MyEnum(string name);
}