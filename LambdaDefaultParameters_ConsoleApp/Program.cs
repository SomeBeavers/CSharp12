const int myParameter = 1;
var simpleLambda = (int x) => x;

var simpleLambda2 = simpleLambda(1);

Console.WriteLine(simpleLambda2);
Console.WriteLine(simpleLambda(2));


var myLambda = (int x = 1) =>
{
    x = 2;
    return x + 1;
};

Console.WriteLine(myLambda()); 
Console.WriteLine(myLambda(1));
Console.WriteLine(myLambda(arg: 2));
Console.WriteLine(myLambda(3));

var defaultValue = myLambda.Method.GetParameters()[0].DefaultValue;


var myLambdaWithParams = (params int[] myParams) => myParams[1].ToString();

string s = "";

int Test(int x = myParameter)
{
    x = 2;
    return x + 1;
}



//Console.WriteLine(myLambdaWithParams());
Console.WriteLine(myLambdaWithParams(1,2,3,4));
Console.WriteLine(myLambdaWithParams(arg: new[] { 1, 2, 3, 4 }));

var addWithDefault = (int addTo = 2) => addTo + 1;
addWithDefault(); // 3
addWithDefault(5); // 6

var counter = (params int[] xs) => xs.Length;
counter(); // 0
counter(1, 2, 3); // 

var addWithDefault2 = AddWithDefaultMethod;
addWithDefault2(); // 3
addWithDefault2(5); // 6

var counter2 = CountMethod;
counter2(); // 0
counter2(1, 2); // 2

int AddWithDefaultMethod(int addTo = 2)
{
    return addTo + 1;
}
int CountMethod(params int[] xs)
{
    return xs.Length;
}

