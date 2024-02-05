using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    internal class Attribute_PartialClass
    {
        public Attribute_PartialClass()
        {
            //ClassPart classPart = [new(), new Pet()];
            List<int> list = [1, 2, 3];

            NewClass cNewClass = [new Pet()];
            InClass1 class1 = [new Pet()];

            List<int> list1 = (List<int>)[1,2,3];

            CustCollection custCollection = (CustCollection)[1,2];

            NewCollection collection = [];
        }

    }

    
    public partial class ClassPart(string name)
    {
        public void Text()
        {

        }
    }

    [CollectionBuilder(typeof(BuilderStruct), "CreateClass")]
    public class NewClass
    {

    }

    [CollectionBuilder(typeof(BuilderStruct), nameof(BuilderStruct.CreateClass))]
    public class InClass : NewClass
    {

    }
    [CollectionBuilder(typeof(BuilderStruct), nameof(BuilderStruct.CreateClass))]
    public class InClass1 : InClass
    {

    }

    public class CustCollection : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(int i)
        {
            throw new NotImplementedException();
        }
    }

    [CollectionBuilder(typeof(BuilderStruct), "CreateClass")]
    public class NewCollection
    {
        public static IEnumerator<Pet> GetEnumerator() => throw null;
    }
}
