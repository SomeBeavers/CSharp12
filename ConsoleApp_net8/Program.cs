using ConsoleApp_net8;
using static ConsoleApp_net8.Class1;

var name = new Class1().GetName(name => $"Cool Name: {name}");
Console.WriteLine(name);

var name2 = new Class1().GetName2((string name = "John Doe") => $"Cool Name: {name}");
Console.WriteLine(name2);