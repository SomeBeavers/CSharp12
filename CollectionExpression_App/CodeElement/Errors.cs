using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    public class Errors
    {
        public void Test()
        {
             //CustomCollection collection = ["f", "d"];
            //AbsClass absClass = [1,2,3];
            //CustomCollection cust = [1, 2];
            //AnotherCollection collection = [new Pet()];
            var pet = new Pet();

            //AnotherCollection c = [new Pet(), pet, null];

            //AnotherCollection cl = [new Pet(), pet, null, ..new Pet[3]];

            var arr = new int[3];
            arr = [1, 2, 3, 4, 5];
            MyCollectionNew collectionNew = new MyCollectionNew();

            //List<object> newList = [..collectionNew];

            //List<Pet> list = [..cl];

            ImmutableArray<int> array = [];

            //ReqMembersClass tmp1 = [];
            //Void collection = [1];
            //void* iVoid = [];
            //List<int> ints = [1, null];

        }

        public void Test2() { }
    }

    public class CustomCollection : IEnumerable
    {
        //public CustomCollection(int d) { }

        private CustomCollection()
        {

        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(string s)
        {
            throw new NotImplementedException();
        }

        public void Add(int i)
        {

        }

    }

    public abstract class AbsClass : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(int i)
        {
            throw new NotImplementedException();
        }
    }

    public class AnotherCollection : IEnumerable
    {
        private IEnumerator<Pet> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        //public IEnumerator<int> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Add(int i)
        {
            throw new NotImplementedException();
        }

    }

    public class ReqMembersClass
    {
        public required string Prop { get; set; }
    }
    public class MyCollectionNew 
    {
        int[] items;
        public MyCollectionNew()
        {
            items = new int[5] { 12, 44, 33, 2, 50 };
        }

        // Delete the following line to resolve.  
        MyEnumerator GetEnumerator()

            // Uncomment the following line to resolve:  
            //public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        // Declare the enumerator class:  
        public class MyEnumerator
        {
            int nIndex;
            MyCollectionNew collection;
            public MyEnumerator(MyCollectionNew coll)
            {
                collection = coll;
                nIndex = -1;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < collection.items.Length);
            }

            public int Current => collection.items[nIndex];
        }

    }

}
