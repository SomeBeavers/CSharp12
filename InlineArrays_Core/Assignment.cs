namespace InlineArrays_Core;

public class Assignment
{
	void M1(Buffer10<int> x)
	{
		Span<int> a = x[..]; // Ok, equivalent to `System.Span<int> a = InlineArrayAsSpan<Buffer10<int>, int>(ref x, 10).Slice(0, 10)`
	}

	void M2(in Buffer10<int> x)
	{
		System.ReadOnlySpan<int> a = x[..]; // Ok, equivalent to `System.ReadOnlySpan<int> a = InlineArrayAsReadOnlySpan<Buffer10<int>, int>(in x, 10).Slice(0, 10)`
		foreach (var i in x[..1])
		{
		}

		ReadOnlySpan<int> span = x[..2];
		//System.Span<int> b = x[..]; // An error, System.ReadOnlySpan<int> cannot be converted to System.Span<int>
	}

	Buffer10<int> GetBuffer() => default;

	void M3()
	{
		//_ = GetBuffer()[..]; // An error, `GetBuffer()` is a value
	}
}