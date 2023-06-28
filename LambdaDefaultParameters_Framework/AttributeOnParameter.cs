using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace LambdaDefaultParameters_Framework;

public class AttributeOnParameter
{
    public delegate int MyDelegate(string name, [My] int age = 18);
    public void Test()
    {
        var addWithDefault = ([NotNull] int? addTo = 1) => addTo + 1;

        addWithDefault();
        addWithDefault();
        addWithDefault(null);

        var a = (int i = 13) => 1;
        // same as
        var b = ([Optional] [DefaultParameterValue(13)] int i) => 1;
        a = b;


        var lambda1 = (string name, [My] int age = 18) =>
        {
            return new { Name = name, AgeOfConsent = age };
        };

        var result = lambda1("");

        MyDelegate delegateForLambda1 = (string name, [My] int age = 18) =>
        {
            return age ;
        }; ;
    }
}

public class MyAttribute : Attribute
{
}