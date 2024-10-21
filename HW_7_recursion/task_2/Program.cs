// Описание: Напишите программу для вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Ackermann(int n, int m)
{
    // if (m == 0)
    // {
    //     return n + 1;
    // }
    // else if (m > 0 && n == 0)
    // {
    //     return Ackermann(m - 1, 1);
    // }
    // else if (m > 0 && n > 0)
    // {
    //     return Ackermann(m - 1, Ackermann(m, n - 1));
    // }
    // return 0;

    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackermann(n - 1, 1);
    }
    else
    {
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }
}

Console.Write("Введите неотрицательное число n: \n");
int first_num = Convert.ToInt32(Console.ReadLine());
if (first_num < 0) 
{
    Console.WriteLine("Число должно быть неотрицательным");
    Environment.Exit(0);
}

Console.Write("Введите неотрицательное число m: \n");
int second_num = Convert.ToInt32(Console.ReadLine());
if (second_num <= 0) 
{
    Console.WriteLine("Число должно быть неотрицательным");
    Environment.Exit(0);
}

int result = Ackermann(first_num, second_num);
Console.WriteLine($"{result}");