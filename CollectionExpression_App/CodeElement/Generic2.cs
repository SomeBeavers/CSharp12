namespace CollectionExpression_App.CodeElement;

public class Generic2<T> where T : BaseT, new()
{
    public T Value { get; set; }

    public void Test(T? i, BaseT pBaseT, T[] arrT)
    {
        if (i != null)
        {
            List<BaseT> list =
            [
                new T(), i, Value, (T)pBaseT, pBaseT, ..arrT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT,
                pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT, pBaseT
            ];
        }
    }
}

public class BaseTBase
{
}

public class BaseT : BaseTBase
{
}

public class BaseTImpl : BaseT
{
}

public class Bat
{

}

public class UseGeneric2<T> where T : BaseT, new()
{
    public Generic2<T> Generic2;

    public T? Method()
    {
        return null;
    }

    public int Method2()
    {
        return 0;
    }

    public void Test2()
    {
        //List<T> list = new() { (T)new BaseT(), new Bat() as T, (T)new BaseTBase(), new BaseTImpl() };
        List<string> list2 = new() { "dfsd", "sf" };
    }

    // ReSharper disable once InconsistentNaming
    // ReSharper disable once UnusedParameter.Global
    public void Test(List<Generic2<T>> paGeneric2s)
    {
        //Generic2 = new Generic2<T>();
        //var x = (new List<Generic2<T>>() { Generic2 } ?? []).First();
        //Generic2<T> tmp = Method();
        //List<Generic2<T>> generic2s = [Generic2, new Generic2<T>(), .. new List<Generic2<T>>() {Generic2} ?? [], x, Method()];
        //string t = Method2();
        //List<string> list2 = new List<string>() { Method2()};
        //List<string> list = [Method2()];

        List<T> list = new() { (T)new BaseT(), new Bat() as T, (T)new BaseTBase()};

    }
}