using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] numbersStr = input.Split(' ');

        int[] numbers = new int[numbersStr.Length];
        for (int i = 0; i < numbersStr.Length; i++)
        {
            numbers[i] = int.Parse(numbersStr[i]);
        }

        int max = FindMax(numbers);
        Console.WriteLine($"Наибольшее значение в массиве: {max}");
    }

    static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
}
