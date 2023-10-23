using System.Runtime.CompilerServices;
using InlineArrays_CoreLib;using InlineArrays_Nuget;

Console.WriteLine("Hello, World!");
var point = new Point();
var i = point[1];

var nuget1 = new Nuget1();
//nuget1.Name = "John Doe";
var s = nuget1[1];


NewFunction(out var referencedStruct2);

void NewFunction(out ReferencedStruct1 referencedStruct1)
{
	referencedStruct1 = new ReferencedStruct1();
	referencedStruct1[9] = 2;
}


class UsePoint
{
	public void Test()
	{
		var point = new Point();
		point[1] = 2;
	}
}

[InlineArray(3)]
internal struct Point
{
	private static int Length = 10;
	public int X;

	public Point()
	{
		X = 0;
	}
}


[InlineArray(1)]
internal record struct MyStruct(int t)
{
}