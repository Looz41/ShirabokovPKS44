using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы первого массива (через пробел):");
        int[] array1 = ReadIntArrayFromConsole();

        Console.WriteLine("Введите элементы второго массива (через пробел):");
        int[] array2 = ReadIntArrayFromConsole();

        int[] mergedArray = MergeArrays(array1, array2);

        Console.WriteLine("Объединенный массив: [" + string.Join(", ", mergedArray) + "]");
    }

    static int[] ReadIntArrayFromConsole()
    {
        string input = Console.ReadLine();
        string[] strArray = input.Split(' ');
        int[] intArray = new int[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            intArray[i] = int.Parse(strArray[i]);
        }
        return intArray;
    }

    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int totalLength = arr1.Length + arr2.Length;
        int[] mergedArray = new int[totalLength];

        for (int i = 0; i < arr1.Length; i++)
        {
            mergedArray[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            mergedArray[arr1.Length + i] = arr2[i];
        }

        return mergedArray;
    }
}
