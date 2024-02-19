using System.Collections;

namespace CollectionExpression_App.Usages;

public class InLambda
{
    public void Test(List<int> list)
    {
        List<int> s = [..list.Where(x => x > 0)];

        foreach (var ints in list.Where(x => x > 0).Select<int, List<int>>(x => [x, 1])) Console.WriteLine(ints);

        List<int> Ints(int x)
        {
            return [x];
        }

        var s2 = ((List<int>) [..Ints(1)])[1..2];
        var i = ((int[]) [1, 2])[^1];

        using ((MyCollection<int>) [1, 2, 3])
        {
        }
    }

    public unsafe void Test2(int* s)
    {

        int*[] s1;
        s1 = [s, ];
        int[] s2 = [1,2,3];
        //ReadOnlySpan<ReadOnlySpan<byte>> x = ["abc"u8];
        ReadOnlySpan<byte> x1 = "abc"u8;
    }

    private class MyCollection<T> : IEnumerable, IDisposable
    {
        public void Dispose()
        {
            // TODO release managed resources here
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T i)
        {
            throw new NotImplementedException();
        }
    }
}