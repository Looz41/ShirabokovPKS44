using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица умножения:");

        Console.Write("  ");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine("\n----------------------------------------");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i,2}|");
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
}
