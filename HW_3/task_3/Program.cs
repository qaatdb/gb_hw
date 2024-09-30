// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов массива.

using System;
using System.Linq;
class Program
{
    static double CalculateAverage(int[] numbers)
    {
        double result = 0;
        for (int i=0; i < numbers.Length; i++) {
            result += numbers[i];
        }
        result = result / numbers.Length;
        return result;
    }
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива
        double average = CalculateAverage(numbers);
        Console.WriteLine(average);
    }
}