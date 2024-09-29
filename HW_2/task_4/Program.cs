// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number != 0 && number > 0)
{
    int symbol_count = 0;
    int counter = number;
    while (counter > 0)
    {
        symbol_count++;
        counter = counter / 10;
    }
    //Console.WriteLine($"Количество символов в числе - {symbol_count}");
    while (number > 0)
    {
        int multiplier = 1;
        for (int j = 1; j < symbol_count; j++)
        {
            multiplier *= 10; // ищу делитель для того, чтобы найти первую цифру в числе
        }
        if (number % multiplier > 0)
        {
            Console.Write($"{number / multiplier}, "); //вывожу первую цифру
        }
        else
        {
            Console.Write($"{number / multiplier}");
        }
        number = number % multiplier; //далее надо вывести вторую цифру и т.д. в цикле
        //Console.WriteLine(number); //дебаг своеобразный
        symbol_count--; //при этом количество цифр в числе уменьшается по мере вывода
    }
}
else
{
    Console.WriteLine("Число не является натуральным.");
}