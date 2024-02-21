using CollectionExpression_App.CodeElement;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App
{
    public class RearrangeCode
    {
        public void Test()
        {
            //StringBuilder stringBuilder = [new StringBuilder().Append('d').ToString()];
            string[] s = [""];
            ImmutableArray<string> list =
            [
                ..new string[] { }, string.Empty, ..s, ..new[] { "dhf", "fg" },
                .. ((string[]) [.. s])[1..],            
                ..new List<string> { "ewewef", "de" }.Select(x => x.ToUpper()).Where(c => c.EndsWith('f'))
            ];

            List<string> list3 = [myClass.Name, .. myClass.List, myClass.List.FirstOrDefault(), myClass.Name ?? string.Empty];
            var x = 3 + 4;
        }
    }

    public class myClass
    {
        public static string Name { get; set; }
        public static IEnumerable<string> List { get; set; }
    }
}
