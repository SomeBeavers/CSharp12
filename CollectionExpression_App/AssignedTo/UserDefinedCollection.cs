using System.Collections;

namespace CollectionExpression_App.AssignedTo;

public class UserDefinedCollection
{
    public class AnotherCollection<T> : IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw null;
        }

        public void Add(T l)
        {
            throw null;
        }
    }

    public class UseAnotherCollection(AnotherCollection<string>? collection)
    {
        public void Test()
        {
            if (collection != null)
            {
                collection.Add("Hello");
                collection.Add("World");
            }
            else
            {
                collection = ["Hello", "World"];
            }
        }
    }

    public class UseAnotherCollection2<T>(AnotherCollection<T?>? collection) where T : new()
    {
        public void Test(AnotherCollection<T?> parameters, T? t)
        {
            if (collection != null)
                foreach (var p in parameters)
                    collection.Add(p);
            else
                // ReSharper disable once ArrangeObjectCreationWhenTypeNotEvident
                collection = [..parameters, new(), t ?? new()];
        }
    }

    public void Test()
    {
        Range[] ranges = [new(1, 10), new(20, 30), Range.All, Range.EndAt(1) ];
        //int[,] array2D = [ { 1, 2 }, { 3, 4 }, { 5, 6 } ];
        ObsoleteClass[] obsoleteClasses = [new ObsoleteClass(), new ObsoleteClass()];
    }

    [Obsolete("This class is obsolete")]
    public class ObsoleteClass
    {

    }
}