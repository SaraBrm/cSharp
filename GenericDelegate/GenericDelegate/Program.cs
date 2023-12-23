//Generic Delegate

MyDelegate<int> del = Sum;
Console.WriteLine($"sum is : {del(10, 20)}");

MyDelegate<int> del1 = Subtract;
Console.WriteLine($"subtract is : {del1(10, 20)}");

MyDelegate<string> del2 = Concat;
Console.WriteLine($"concat is : {del2("Hello ", "World!")}");

Console.ReadKey();

static int Sum(int number1, int number2)
{
    return number1 + number2;
}

static int Subtract(int number1, int number2)
{
    return number1 - number2;
}
static string Concat(string str1, string str2)
{
    return str1 + str2;
}

public delegate T MyDelegate<T>(T p1, T p2);
//public delegate int MyDelegate1(int str1, int str2);
//public delegate string MyDelegate2(string str1, string str2);