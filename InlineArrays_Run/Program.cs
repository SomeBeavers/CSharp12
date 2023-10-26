// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var point = new Point();
var i = point[1];

[InlineArray(Length)]
internal struct Point
{
	private const int Length = 10;
	public int X;

	public Point()
	{
		X = 0;
	}
}