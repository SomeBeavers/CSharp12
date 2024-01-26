using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    internal class Cast
    {
        public Cast()
        {
        }

        public void Test()
        {
            List<BaseClass> list = [..(ImmutableArray<BaseClass>)[]];
            List<BaseClass> list2 = [..new Pes[2] as IEnumerable<BaseClass>];
            List<List<BaseClass>> list3 = [[], []];
            //List<Pes> list2 = new() { ((IEnumerable<BaseClass>)new Pes[2]).First() };
        }
    }

    public class Pes : BaseClass
    {

    }

    public class BaseClass
    {
    }
}
