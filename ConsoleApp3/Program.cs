using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();

        if (IsNumeric(input))
        {
            if (IsPalindrome(input))
            {
                Console.WriteLine("Да, это палиндром.");
            }
            else
            {
                Console.WriteLine("Нет, это не палиндром.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Вы ввели не число!");
        }
    }

    static bool IsNumeric(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
