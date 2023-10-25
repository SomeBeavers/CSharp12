using static InlineArrays_Core.UseMethod;

namespace InlineArrays_Core;

public class UseMethod
{

	public void GetInlineArray()
	{

	}

	public ReadOnlySpan<int> Test1(in UseMethodStruct<int> parameter)
	{
		return parameter[0..1];
	}
	public UseMethodStruct<int> Test1(UseMethodStruct<int> parameter, int t)
	{
		ReadOnlySpan<int> parameter2 = Test1(in parameter);

		var parameterTt = parameter.InlineArrayParameter;

		parameter[0] = t;
		return parameter;
	}



	[InlineArray(10)]
	public struct UseMethodStruct<T>
	{
		public T InlineArrayParameter;
		//private  T InlineArrayParameter ;
	}
}