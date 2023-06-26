namespace LambdaDefaultParameters_Multi;

public class Multi1
{
    public void Test(InnerClass innerClass)
    {
        var lambda1 = (InnerClass @class = null) => @class.Name;
        var converter = (InnerClass parameter = null) => parameter.Name;
        lambda1();

        Func<InnerClass, string> func = (InnerClass parameter = null) => parameter.Name;
        /*caret*/
        //UseLambda(lambda1);
    }

    private void UseLambda(Func<InnerClass, string> lambda1)
    {

    }
}

public class InnerClass
{
    public string Name { get; set; }
}