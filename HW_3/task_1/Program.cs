// Описание: Задайте массив целых чисел.
// Напишите программу, которая проверяет, присутствует ли заданное число в массиве.
// Программа должна вывести: Присутствует/Не присутствует.

using System;
class Program
{
    static bool IsNumberPresent(int[] numbers, int numberToFind)
    { 
        //bool result = false;
        for (int i = 0; i < numbers.Length; i++) {
            if (numbers[i] == numberToFind){
                return true;
            }
            // else {
            //     result = false;
            // }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 19, 3 }; // Пример массива
        int numberToFind = 19; // Пример числа для поиска
        if (IsNumberPresent(numbers, numberToFind)) // если true То 
        {
            Console.WriteLine("Присутствует");
        }
        else // если false то
        {
            Console.WriteLine("Не присутствует");
        }
    }
}