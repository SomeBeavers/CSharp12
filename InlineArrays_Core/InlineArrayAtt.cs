namespace InlineArrays_Core;

//[System.Runtime.CompilerServices.InlineArray(2)]
public class InlineArrayAtt
{

}

[System.Runtime.CompilerServices.InlineArray(10)]
record struct Struct1(int Length);

//[InlineArray(1)]
record Record1(int Length);

//[InlineArray(1)]
public enum MyEnum
{
	A
}

//[InlineArray(1)]
interface IInterface
{
	
}