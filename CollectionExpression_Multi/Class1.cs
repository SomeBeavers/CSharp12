using System.Collections;

namespace CollectionExpression_Multi
{
    public class Class1
    {
#if NET8_0
        public IEnumerable<int> e = [1];
#else 
        private IEnumerable<int> e = new List<int> { 1, 2 }.AsReadOnly();
#endif

    }
}
