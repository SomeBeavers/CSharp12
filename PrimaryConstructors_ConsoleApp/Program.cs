// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
new TopLevelClass();
var topLevelStruct = new TopLevelStruct("test");
foreach (var s in topLevelStruct)
{
	Console.WriteLine(s);
}

class TopLevelClass;

[InlineArray(10)]
struct TopLevelStruct(string name)
{
	public string Name { get; set; } = name;
}

record TopLevelRecord(string name)
{
};
