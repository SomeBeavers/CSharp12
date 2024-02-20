using System.Collections;
using System.Numerics;

namespace CollectionExpression_App.Usages;

public class Overload
{
    class C1 : IEnumerable<char>
    {
        public static void M1(C1 x)
        {
        }
        public static void M1(char[] x)
        {
        }

        void Test()
        {
            //M1(['a', 'b']); // error CS1061: 'C1' does not contain a definition for 'Add' and no accessible extension method 'Add' accepting a first argument of type 'C1' could be found (are you missing a using directive or an assembly reference?)
        }

        public static implicit operator char[](C1 x) => throw null;
        IEnumerator<char> IEnumerable<char>.GetEnumerator() => throw null;
        IEnumerator IEnumerable.GetEnumerator() => throw null;
    }

    class C2
    {
        static void Generic<T>(Span<T> value) { }
        static void Generic<T>(T[]     value) { }

        static void SpanDerived(Span<string> value) { }
        static void SpanDerived(object[]     value) { }

        static void ArrayDerived(Span<object> value) { }
        static void ArrayDerived(string[]     value) { }

        public void Test2()
        {
            // Array initializers
            Generic(new[] { "" });      // string[]
            //SpanDerived(new[] { "" });  // ambiguous
            ArrayDerived(new[] { "" }); // string[]

            // Collection expressions
            Generic([""]);              // Span<string>
            SpanDerived([""]);          // Span<string>
            //ArrayDerived([""]);         // ambiguous
        }
        public static void M1(char[] x)
        {
        }
        public static void M1(string x)
        {
        }

        void Test()
        {
            //M2([1,2,3]);
       

        }

        private void M2(List<int> ints)
        {
            throw new NotImplementedException();
        }

        private void M2(int[] ints)
        {
            throw new NotImplementedException();
        }


    }
}