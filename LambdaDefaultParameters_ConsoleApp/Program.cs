// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const int myParameter = 1;

var myLambda = (int x = myParameter) => x + 1;

void Test(int x = myParameter)
{
}

Console.WriteLine(myLambda);