// Описание: Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Используйте рекурсию и не используйте циклы.


void PrintNaturalNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        if (m == n)
        {
            return;
        }
        PrintNaturalNumbers(m + 1, n);
    }
    else
    {
        Console.Write($"{n} ");
        if (n == m)
        {
            return;
        }
        PrintNaturalNumbers(n + 1, m);
    }
}

Console.Write("Введите натуральное число M: \n");
int first_num = Convert.ToInt32(Console.ReadLine());
if (first_num <= 0) 
{
    Console.WriteLine("Число не является натуральным");
    Environment.Exit(0);
}

Console.Write("Введите натуральное число N: \n");
int second_num = Convert.ToInt32(Console.ReadLine());
if (second_num <= 0) 
{
    Console.WriteLine("Число не является натуральным");
    Environment.Exit(0);
}

PrintNaturalNumbers(first_num, second_num);