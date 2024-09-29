// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите натуральное число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number != 0 && number > 0) {
//     string s1 = Convert.ToString(number);
//     for (int i = 0; s1.Length; 1) {
//         Console.Write($"{s1[i]}" + " ");
//     }
// }
// else {
//     Console.WriteLine("Число не является натуральным.");
// }


// РАБОТАЮЩИЙ ВАРИАНТ

// Console.Write("Введите натуральное число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number != 0 && number > 0) {
//     while (number > 0) {
//         Console.Write($"{number % 10}, ");
//         number = number / 10;
//     }
// }
// else {
//     Console.WriteLine("Число не является натуральным.");
// }

using System.Runtime.InteropServices;

Console.Write("Введите натуральное число N: ");
// 999
int number = Convert.ToInt32(Console.ReadLine());
if (number != 0 && number > 0)
{
    int i = 0;
    int counter = number;
    while (counter > 0)
    {
        i++;
        counter = counter / 10;
    }
    Console.WriteLine($"Количество символов в числе - {i}");
    // 3
    //Console.WriteLine(number);
    while (number > 0)
    {
        int multiplier = 1;
        for (int j = 1; j < i; j++)
        {
            multiplier *= 10;
            //Console.WriteLine(multiplier);
        }
        Console.Write($"{number / multiplier}, ");
        // //Console.WriteLine(i);
        number = number % multiplier;
        //Console.WriteLine(number);
        i--;
    }
}
else
{
    Console.WriteLine("Число не является натуральным.");
}





//Пример идеального решения - работает не идеально
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите натуральное число N: ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         if (N < 10)
//         {
//             Console.WriteLine(N);
//         }
//         else
//         {
//             while (N > 0)
//             {
//                 int currentDigit = N % 10;
//                 N /= 10;
//                 if (N > 0)
//                 {
//                     Console.Write(currentDigit + ",");
//                 }
//                 else
//                 {
//                     Console.WriteLine(currentDigit);
//                 }
//             }
//         }
//     }
// }