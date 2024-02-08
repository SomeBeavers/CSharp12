using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    public class AnonymousType
    {
        public static int Amount { get; set; }

        public void Test()
        {
            var fruit = new Fruit();
            var apple = new Apple();
            var v = new {Amount = 100, Message = "Hello" };
            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };
            List<object> list2 = [1, new {}, v];
            List<object> list =
            [
                new { Amount = 5, Message = "t" }, v, new { prop = v, fruit},
                new { test = new { a = true, b = new { t = "t" } } },
                list2, fruit,
                ((object[])[new {t = true, apple }])[1], anonArray, ..list2, v with {Amount = 5},
                (object[])[anonArray], apple, new object()
            ];
            IEnumerable<object> enumerable = [list];
        }
    }

    public class Fruit
    {
        public string Color { get; set; }
        public string Name { get; set; }
    }

    public class Apple : Fruit
    {
        public string Type { get; set; }
    }
}
