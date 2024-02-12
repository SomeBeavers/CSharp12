using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionExpression_App.CodeElement;

namespace CollectionExpression_App
{
    public class Refactorings
    {
        private List<string> _list2;

        public void Method()
        {
            List<string> renamed = ["fd", "d"];
            string? s = null, s1 = "test";
            _list2 = [..renamed, s, "d", s1];
            List<string> list2 = _list2;

            var userRenamed = new UserRenamed();
            IEnumerable<UserRenamed> users = Users(userRenamed);

            var tmp = new UserDefinedType();
            UserDefinedType[] arrTypes = [tmp, new UserDefinedType()];
            UserCollection collection = ["d", "dfsdf"];
            collection.GetEnumerator();

            List<int> ints = [list2.Count, arrTypes.Length];

            List<int> list = [1,2,3];

            IEnumerable<IEnumerator<UserRenamed>> lists = [..(IEnumerator<UserRenamed>[])[users.GetEnumerator()]];
        }

        private static IEnumerable<UserRenamed> Users(UserRenamed userRenamed)
        {
            return [new(), userRenamed];
        }
    }

    public class UserRenamed
    {
        
    }

    public class UserCollection : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(string s)
        {
            throw new NotImplementedException();
        }
    }
}
