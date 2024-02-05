// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int rt;
//List<int> list = [3, 4, 5, 6, 7, 8, 9];
//list = [];
//List<int> y = [1, 2, list];
//[1,2];
//using System;

using CollectionExpression_App.CodeElement;

string? s = null;
List<string> list2 = [s];
ClassStruct classStruct = [new Pet(), new Pet()];
Console.WriteLine(classStruct.name);

public class RefClass
{
    List<int> list = [1, 2, new ProjectReference.Class1().p, ..new CollectionExpression_Multi.Class1().e];
    
}


