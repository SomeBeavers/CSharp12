using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDefaultParameters_Framework;

internal class Program
{
    private static void Main(string[] args)
    {
        var func = (int t1 = 1, string s = "my string is here") => s + "test";

        
        var a = (string x = "1") => x == String.Empty;
        a?.Invoke();
        a?.Invoke("1");
        a(1.ToString());
        a?.Invoke(2.ToString());

        new List<int>().Where((int x = 1) => x == 1);
    }
}