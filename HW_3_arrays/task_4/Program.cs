// Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все отрицательные числа из массива и возвращает новый массив,
// содержащий только неотрицательные числа.

using System;
using System.Linq;
class Program
{
    static int[] RemoveNegatives(int[] numbers)
    {
        int newSize = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 0)
            {
                newSize++;
            }
        }
        int[] newNumbers = new int[newSize];
        int j = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 0)
            {
                newNumbers[j] = numbers[i];
                j++;
            }
        }
        return newNumbers;
    }
    static void Main(string[] args)
    {
        int[] numbers = { 5, -3, 9, -1, 2, -7, 0 };// Пример массива
        int[] result = RemoveNegatives(numbers);
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}