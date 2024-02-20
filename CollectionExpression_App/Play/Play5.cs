#nullable disable

using CollectionExpression_App;
using System.Diagnostics.CodeAnalysis;

namespace CollectionExpression_App.Play1
{
    public interface IInheritance<T>
    {
        string Name { get; }

        List<T> Test(List<T> list);
        //List<T> Test(T[] list);
    }

    public class Inheritance<T> : IInheritance<T>
    {
        public string Name => throw new NotImplementedException();
        public List<T> Test(List<T> list)
        {
            return [];
        }

        public List<T> Test(T[] list)
        {
            throw new NotImplementedException();
        }
    }

    public class Inheritance2<T> : Inheritance<T>
    {

    }

    public class Inheritance3<T> : Inheritance<T>
    {
    }

    public class UseInheritance
    {


        public void Test(List<IInheritance<int>> list)
        {
            List<IInheritance<int>> list2 = [new Inheritance2<int>(), new Inheritance3<int>()];

            foreach (var inheritance in from inheritance in list let inheritanceName = inheritance.Name select inheritance)
            {
                inheritance.Test([1, 2, 3]);
            }

            //var a = GetA([new A()]);

            //if (a == null)
            //{

            //}

            //bool[] s = [false, a.Equals(null)];
        }

        public A GetA(A[] list)
        {
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            IA[] empty = [];
            return new A();
        }

        public void Test3()
        {
            var a = GetA([new A()]);
        }

    }

    public interface IA
    {
    }

    public class A : IA
    {
    }
}

namespace A1
{
    public class B
    {
        public A GetA(/*caret*/IEnumerable<A> list)
        {
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            IA[] empty = [];
            return new A();
        }

        public void Test3()
        {
            var a = GetA([new A()]);
        }
    }
    public interface IA
    {
    }

    public class A : IA
    {
    }
}
