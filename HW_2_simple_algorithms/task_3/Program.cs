// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите целое число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10 || number > 99) 
{
    Console.WriteLine("Число выходит за допустимый диапозон");
}
else {
    int num_1 = number / 10;
    int num_2 = number % 10;
    if (num_1 > num_2) {
        Console.WriteLine($"Наибольшая цифра - {num_1}");
    }
    else {
        Console.WriteLine($"Наибольшая цифра - {num_2}");
    }
}