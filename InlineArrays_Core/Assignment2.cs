namespace InlineArrays_Core;

public class Assignment2
{
	void M1(Buffer10<int> x)
	{
		System.ReadOnlySpan<int> a = x; // Ok, equivalent to `System.ReadOnlySpan<int> a = InlineArrayAsReadOnlySpan<Buffer10<int>, int>(in x, 10)`
		System.Span<int> b = x; // Ok, equivalent to `System.Span<int> b = InlineArrayAsSpan<Buffer10<int>, int>(ref x, 10)`
	}

	void M2(in Buffer10<int> x)
	{
		System.ReadOnlySpan<int> a = x; // Ok, equivalent to `System.ReadOnlySpan<int> a = InlineArrayAsReadOnlySpan<Buffer10<int>, int>(in x, 10)`
		//System.Span<int> b = x; // An error, readonly mismatch
	}

	Buffer10<int> GetBuffer() => default;

	void M3()
	{
		//System.ReadOnlySpan<int> a = GetBuffer(); // An error, ref-safety
		//System.Span<int> b = GetBuffer(); // An error, ref-safety
	}
}