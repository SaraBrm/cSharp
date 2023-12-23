//Multicast Delegate

MathDelegate del = Sum;
del += Max;
//del -= Sum;
del(10, 20);

Console.ReadKey();


static void Sum(int number1, int number2)
{
    Console.WriteLine($"sum : {number1 + number2}");
}

static void Max(int number1, int number2)
{
    int max =Math.Max(number1, number2);
    Console.WriteLine($"max is : {max}");
}

public delegate void MathDelegate(int a, int b);
