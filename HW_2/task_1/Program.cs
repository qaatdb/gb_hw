// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите целое число ");
long number = Convert.ToInt64(Console.ReadLine());
if ((number % 7 == 0) && (number % 23 == 0)) {
    Console.WriteLine("Число кратно одновременно и 7, и 23");
}
else {
    Console.WriteLine("Число не кратно 7 и 23 одновременно");
}