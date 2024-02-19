namespace CollectionExpression_App.Usages;

public class UseMethod
{
    delegate int TestDelegate();
    public int[] Test()
    {
        return [1,2,3];
    }

    public void Test2()
    {
        TestDelegate testDelegate = GetInt;
        List<int> s = [.. Test(), GetInt(), LocalFunc(1), testDelegate()];
        TestDelegate testDelegate2 = () => 1;

        List<TestDelegate> list = [testDelegate, () => 1, TestDelegate, null!];

        int TestDelegate()
        {
            throw new NotImplementedException();
        }

        int LocalFunc(int i)
        {
            return i + 1;
        }
    }

    private int GetInt()
    {
        throw new NotImplementedException();
    }

    static ReadOnlySpan<int> AsSpanConstants()
    {
        return [1, 2, 3]; // ok: span refers to assembly data section
    }

    //static ReadOnlySpan<T> AsSpan2<T>(T x, T y)
    //{
    //    return [x, y];    // error: span may refer to stack data
    //}

    static ReadOnlySpan<T> AsSpan3<T>(T x, T y, T z)
    {
        return (T[])[x, y, z]; // ok: span refers to T[] on heap
    }
}