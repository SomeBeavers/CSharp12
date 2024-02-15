using System.Collections;

namespace CollectionExpression_App.Play;

public class Play2
{
    class UserDefinedCollection1 : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator() => throw null;

        public IEnumerator<string> GetEnumerator() => throw null;
        public void Add(object l) => throw null;
    }

    class Program
    {
        static void Test(UserDefinedCollection1 a)
        {
            a = ["Hello", "World", 1];
        }
    }
}