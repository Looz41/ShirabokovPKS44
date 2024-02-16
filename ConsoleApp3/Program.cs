using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string reversedString = ReverseString(input);
        Console.WriteLine($"Строка в обратном порядке: {reversedString}");
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
