using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.Usages
{
    internal class InExpressionTree
    {
        public void Test()
        {
            Expression expression = ((List<int>) [1, 2, 3, 4]).AsQueryable().Where(num => num > 3).Expression;
            Console.WriteLine(expression.ToString());
            //Expression.Constant([1,2], typeof(List<int>));
            Expression<Func<List<int>, double, double>> distanceCalc =
                (x, y) => Math.Sqrt(((int[])[1, 2, 3])[1] + y * y);
            
        }
    }
}
