
//Passing Delegate as a Parameter

int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
NumberPredicate del = IsEven;
var result = FilterArray(Numbers, del);

foreach (var item in result)
{
    Console.Write($" {item}");
}


Console.ReadKey();

static bool IsEven(int number)
{
    return (number % 2 == 0);
}

static bool IsOdd(int number)
{
    return (number % 2 == 1);
}

static List<int> FilterArray(int[] array, NumberPredicate predicate)
{
    List<int> result = new List<int>();
    foreach (int number in array)
    {
        if (predicate(number))
            result.Add(number);
    }
    return result;
}

public delegate bool NumberPredicate(int number);