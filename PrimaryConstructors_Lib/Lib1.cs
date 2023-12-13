namespace PrimaryConstructors_Lib;

public class Lib1(string name, int age)
{
	public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public int Birthday { get; set; } = 0;
}