using System;

class Program
{
    static void Main()
    {
        string[] stringArray = { "фламинго", "коктейль", "экзотика", "лабиринт", "магнолия" };

        while (true)
        {
            Console.Write("Введите новую строку: ");
            string userString = Console.ReadLine();

            if (ArrayContainsString(stringArray, userString))
            {
                Console.WriteLine("Строка найдена!");
                break;
            }
            else
            {
                Console.WriteLine("Строка не найдена. Попробуйте еще раз.");
            }
        }
    }

    static bool ArrayContainsString(string[] array, string searchString)
    {
        foreach (string str in array)
        {
            if (str.Equals(searchString, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }
}
