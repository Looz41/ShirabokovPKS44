using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        long number = long.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"Факториал числа {number} равен {factorial}");
    }

    static long CalculateFactorial(long n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
        }

        long result = 1;
        for (long i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
