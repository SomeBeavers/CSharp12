using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.Play
{
    internal class Play6
    {
        public MyEnum[] Test()
        {
            return new[]
            {
                MyEnum.Value1, 
                MyEnum.Value2,
                #pragma warning disable 618
                MyEnum.Value3
            };

        }
    }

    enum MyEnum
    {
        Value1, Value2, Value3
    }
}
