namespace LambdaDefaultParameter_OldLanguageVersion
{
    public class Class1
    {
        public void Test()
        {
            void M1(int i = 1) { }
            var m1 = M1; // Infers Action<int>
            m1(); // error CS7036: There is no argument given that corresponds to the required parameter 'obj' of 'Action<int>'

            void M2(params int[] xs) { }
            var m2 = M2; // Infers Action<int[]>
            m2(); // error CS7036: There is no argument given that corresponds to the required parameter 'obj' of 'Action<int[]>'

            //var addWithDefault = (int addTo = 2) => addTo + 1; // error CS1065: Default values are not valid in this context.
            //var counter = (params int[] xs) => xs.Length; // error CS1670: params is not valid in this context
        }
    }
}