namespace PrimaryConstructors_ConsoleApp;

public abstract class AbstractClass(string name, int age)
{
	public string Name { get; } = name;
	public int Age { get; } = age;
}

class AbstractClassImpl(string name, int age) : AbstractClass(name, age);