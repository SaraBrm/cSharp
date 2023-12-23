using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter number : ");
            int number = int.Parse(Console.ReadLine());

            int result = Factorial(number);
            Console.WriteLine($"{number}! is : {result}");
        }
        // n! = n * ( n-1 ) ! 
        private static int Factorial(int num)
        {
            if (num <= 1)
                return 1;
            return num * Factorial(num - 1);
        }

    }
}
