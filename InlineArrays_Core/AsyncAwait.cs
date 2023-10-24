using System.Globalization;
using System.Text;
using System;

namespace InlineArrays_Core;

public class AsyncAwait<T>
{
	public async Task<AsyncAwaitStruct<T>> Test(List<AsyncAwaitStruct<T>> list)
	{
		foreach (var asyncAwaitStruct in list)
		{
			foreach (var a in asyncAwaitStruct)
			{
				Console.WriteLine(a);
			}
		}
		await Task.Delay(1000);


		//await foreach (var a in asyncAwaitStruct)
		//{
		//	Console.WriteLine(a);
		//}

		return default;
	}
}

[InlineArray(10)]
public struct AsyncAwaitStruct<T>
{
	public T? T1;
}