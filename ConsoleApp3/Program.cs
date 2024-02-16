using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        int length = CalculateStringLength(input);
        Console.WriteLine($"Длина строки \"{input}\" равна {length}");
    }

    static int CalculateStringLength(string str)
    {
        return str.Length;
    }
}