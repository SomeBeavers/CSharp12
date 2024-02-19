using System.Collections;

namespace CollectionExpression_App.Usages;

public class InCycles
{
    public void Test(MyCollection<int> myOtherCollection, out List<int> collection)
    {
        collection = [];
        int[] list = [1, 2, 3];

        foreach (var i in list)
        {
            if (i % 2 == 0)
            {
                var i1 = collection[^1];
                collection =
                [
                    ..collection,
                    i1 + i,
                    i
                ];
            }
        }

        MyCollection<int> myCollection =
        [
            1,
            2,
            3,
            4,
            5,
            6,
            7
        ];

        while (((int[])[.. myCollection])[0] > 0)
        {
            myCollection = myCollection[1..];
        }

        var ints = (List<int>)[1,2,3,4,5];
        while (ints.Contains(1))
        {
            ints.RemoveAt(0);
            ints = ints[1..];
        }

        List<int> s = [..((List<int>)[1,2,3]).Select(x => ++x)];

        foreach (var i in ints)
        {
            ints = [1,2,3];
            foreach (var i1 in (List<int>)[..ints])
            {
                Console.WriteLine(i1);
            }
            //ints.RemoveAt(0);
        }

        myOtherCollection = myCollection.Aggregate(myOtherCollection, (current, i) => [i, ..current]);
    }


}

public class MyCollection<T> : IEnumerable<T>
{
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(int i)
    {
        throw new NotImplementedException();
    }

    public MyCollection<int> this[Range range]
    {
        get { throw new NotImplementedException(); }
    }
}