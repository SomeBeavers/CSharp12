using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    using Alias = (List<Cat>, string);
    using ValueTuples = List<(int, string)>;

    public class Tuple
    {
        public void Test()
        {
            (int a, string s) d = (a: 4, s: s);
            Alias valueTuple = ([new Cat(), null, .. new Cat[3]], s);
            List<Alias> list = [([new Cat()], s), valueTuple, ([new Cat(), new Cat()], String.Empty), new Alias(), (Alias)valueTuple];
            List<Alias> list2 = [([new Cat()], s), valueTuple, ([new Cat(), new Cat()], String.Empty)];
            Alias valueTuple1 = ([new Cat(), null], s);
            ValueTuples tuples = [(1, String.Empty), d];
            List<(int a, string s, Cat c)> tuples2 = [(a: 4, s: s, c: new Cat()), ];
            List<(List<Cat>, string)> alias = new List<(List<Cat>, string)>() {(new List<Cat>(){new Cat()}, s)};
            Alias alias2 = (new List<Cat>(), s);

            List<(int a, string s, Cat c)> tuples3 = [(a: 4, s: s, new Cat())];

       
        }

        public string s { get; set; }
    }
    public class Test2
    {
        public string s { get; set; }

        public void Test()
        {
            Alias alias2 = (new List<Cat>(), s);
        }
    }
    public class Cat
    {
    }
}
