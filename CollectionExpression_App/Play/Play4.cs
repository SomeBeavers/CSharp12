using System.Runtime.CompilerServices;

namespace CollectionExpression_App.Play
{
    internal class TestClass
    {
        public void Test()
        {
            RecordCollection recordCollection = [new Pet(), new Pet()];
        }
    }

    [CollectionBuilder(typeof(BuilderStruct), nameof(BuilderStruct.CreatenCreate))]
    public record RecordCollection(string name)
    {
        public void Text()
        { }
    }

    public class BuilderStruct
    {
        public static RecordCollection CreatenCreate(ReadOnlySpan<Pet> items)
        {
            throw new NotImplementedException();
        }
    }

    static class ExtStruct
    {
        public static IEnumerator<Pet> GetEnumerator(this RecordCollection x) => throw null; // Roslyn ignores this tricky boy
    }

    public class Pet
    {
    }
}