namespace LambdaDefaultParameters_ConsoleApp;

public class ConstantValues
{
    public delegate void ChatDelegate(char a = 'a');

    private const int FieldSByte = 1;

    public void Test()
    {
        var lambda1 = (sbyte         sb = FieldSByte) => { };
        var lambda2 = (byte          sb = FieldSByte) => { };
        var lambda3 = (ushort        sb = FieldSByte) => { };
        var lambda4 = (uint          sb = FieldSByte) => { };
        var lambda5 = (ulong         sb = FieldSByte) => { };
        var lambda6 = (nuint         sb = FieldSByte) => { };
        var lambda7 = (decimal       sb = FieldSByte) => { };
        ChatDelegate lambda8 = (char sb = 'a') => { };

        lambda1();
        lambda2();
        lambda3();
        lambda4();
        lambda5();
        lambda6();
        lambda7();
        lambda8();

        const MyEnum enumConst = MyEnum.A;

        var lambda9 = (MyEnum a, MyEnum sb = enumConst) => { };

       
    }

    public delegate void Delegate1(int i);

    public void Test2()
    {
        var d = D;

        var lambda2 = (string s = $"""
                                   string: {myS}
                                   bool:{true}
                                   """) => { };
    }

    private const string myS = "VALUE";

    private void D(int i = 1)
    {
        throw new NotImplementedException();
    }
}



public enum MyEnum
{
    A,B,C
}