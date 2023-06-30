#nullable enable
using System;
class Program1
{
    public static void Main(string[] args)
    {
        var lam = (Delegate        d = lam1) => { };
        var action = /*caret*/(int x = 5) => { };
    }

    private const Delegate lam1 = null;
}