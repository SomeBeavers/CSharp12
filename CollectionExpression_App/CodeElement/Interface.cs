using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    internal interface INterface
    {
        void Method();
    }

    [CollectionBuilder(typeof(NewBuilder), "Create")]
    public class TestClass : INterface, IEnumerable
    {
        public void Method()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Use
    {
        public void Test()
        {
            TestClass testClass = [1, 2];
        }
    }

    public class NewBuilder
    {
        public static TestClass Create(ReadOnlySpan<object> items)
        {
            throw new NotImplementedException();
        }
    }
    public static class NewExt
    {
        public static IEnumerator<int> GetEnumerator(this TestClass x) => throw null;
    }
}
