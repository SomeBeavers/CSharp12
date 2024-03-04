using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    internal class SyntaxAmbiguities
    {
        public void Method()
        {
            Range range1 = ..5;
            Range range2 = default;
            int e = 3;
            //Range[] ranges = [range1, .. e, range2];
            var i = 1;
            var d = (X)[i];
            //bool a = true;
            //int b = 3, c = 5;

            //var el = [a ? (int[])[b] : c];

            bool b = true;

            //string[] a = [..b ? [null] : []];

            //a? b ? [c] : d
        }

        public List<int> X { get; set; }
    }
    class C1
    {
        public static void M1(string x)
        {
        }
        public static void M1(char[] x)
        {
        }

        void Test()
        {
            //M1(['a', 'b']); // error CS0121: The call is ambiguous between the following methods or properties: 'C1.M1(string)' and 'C1.M1(char[])'
        }
    }
}
