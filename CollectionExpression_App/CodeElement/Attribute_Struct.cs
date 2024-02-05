using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpression_App.CodeElement
{
    internal class Attribute_Struct
    {
        public void Test()
        {
            ClassStruct classStruct = [new Pet(), new Pet()];
            classStruct.Text();
            Child child = [new Pet()];
            child.Text();
            classStruct = [..child, ..new Child()];

            var classr = new ClassStruct("f") {};
        }
    }

    [CollectionBuilder(typeof(BuilderStruct), nameof(BuilderStruct.CreatenCreate))]
    public record ClassStruct(string  name)
    {
        public void Text()
        {
            
        }
    }
    [CollectionBuilder(typeof(BuilderStruct), nameof(BuilderStruct.Create))]
    public record Child(string name) : ClassStruct(name)
    {
        public Child() : this("y")
        {
        }

        public void Text()
        {
            throw new NotImplementedException();
        }
    }
    public class BuilderStruct
    {
        //public static ClassWithAttr Create(List<bool>   items) => throw null;
        //public static ClassWithAttr Create(ReadOnlySpan<string> items) => throw null;
        //public static ClassWithAttr Create(ReadOnlySpan<long> items) => throw null;
        //public static ClassWithAttr Create(ReadOnlySpan<bool> items)
        //{
        //    throw null;
        //}

        //public static ClassStruct CreatenCreate(ReadOnlySpan<bool> items)
        //{
        //    throw new NotImplementedException();
        //}
        public static ClassStruct CreatenCreate(ReadOnlySpan<bool> items)
        {
            throw new NotImplementedException();
        }

        public static Child Create(ReadOnlySpan<Pet> items)
        {
            throw new NotImplementedException();
        }

        public static ClassStruct CreatenCreate(ReadOnlySpan<Pet> items)
        {
            throw new NotImplementedException();
        }

        public static ClassPart CreateClassPart(ReadOnlySpan<Pet> items, string s)
        {
            throw new NotImplementedException();
        }


        public static NewClass CreateClassNewClass(ReadOnlySpan<Pet> items)
        {
            throw new NotImplementedException();
        }


        public static NewClass CreateClass(ReadOnlySpan<Pet> items)
        {
            throw new NotImplementedException();
        }

        public static NewCollection CreateNewCollection(ReadOnlySpan<Pet> items)
        {
            throw new NotImplementedException();
        }
    }
    static class ExtStruct
    {
        public static IEnumerator<Pet> GetEnumerator(this ClassStruct x) => throw null;
        public static IEnumerator<Pet> GetEnumerator(this ClassPart x) => throw null;
        public static IEnumerator<Pet> GetEnumerator(this NewClass x) => throw null;
        public static IEnumerator<Pet> GetEnumerator(this InClass x) => throw null;
    }

    public class Pet
    {

    }
   

}
