using System.Collections;

namespace CollectionExpression_App.Play;

public class Play3
{
    class MyCollection : IEnumerable<long>
    {
        IEnumerator<long> IEnumerable<long>.GetEnumerator() => throw null;
        IEnumerator IEnumerable.GetEnumerator() => throw null;

        public IEnumerator<string> GetEnumerator() => throw null;

        public void Add(long   l) => throw null;
        public void Add(string l) => throw null;
    }

    class Program
    {
        static void Main()
        {
            //Test("2"); // error CS0029: Cannot implicitly convert type 'string' to 'long'
            //Test(["2"]); // error CS1503: Argument 1: cannot convert from 'collection expressions' to 'string'
            //Test(3); // error CS1503: Argument 1: cannot convert from 'int' to 'string'
            //Test([3]); // Ok

            //MyCollection x1 = ["2"]; // error CS0029: Cannot implicitly convert type 'string' to 'long'
            MyCollection x2 = [3];
        }

        static void Test(MyCollection a)
        {
        }
    }
}