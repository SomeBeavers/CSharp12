using System.Collections;

namespace CollectionExpression_Nuget
{
    public class Class1
    {
        public MyCollection collection = ["s", "r"];
    }
    
    public class MyCollection : IEnumerable
    {
        public IEnumerator<string> GetEnumerator() => throw null;
        IEnumerator IEnumerable.GetEnumerator() => throw null;

        public void Add(string s)
        {
            throw new NotImplementedException();
        }
    }

}
