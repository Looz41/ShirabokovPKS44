using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк массива:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов массива:");
        int cols = int.Parse(Console.ReadLine());

        int[,] array = ReadArrayFromConsole(rows, cols);
        int sum = SumOfArrayElements(array);
        Console.WriteLine($"Сумма всех элементов массива: {sum}");
    }

    static int[,] ReadArrayFromConsole(int rows, int cols)
    {
        int[,] array = new int[rows, cols];

        Console.WriteLine("Введите элементы массива (по одному числу в каждой строке):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Элемент [{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    static int SumOfArrayElements(int[,] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }
}
