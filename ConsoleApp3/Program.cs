using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} - простое число.");
            }
            else
            {
                Console.WriteLine($"{number} - не является простым числом.");
                Console.WriteLine(GetDivisorsMessage(number));
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введенное значение не является числом.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static string GetDivisorsMessage(int num)
    {
        string message = $"Делители числа {num}: ";
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                message += $"{i}, ";
                if (i != num / i)
                {
                    message += $"{num / i}, ";
                }
            }
        }
        return message.TrimEnd(' ', ',');
    }
}
