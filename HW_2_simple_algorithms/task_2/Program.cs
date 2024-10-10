// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки. Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 0)
{
    Console.WriteLine("Ошибка - X не должен быть равен нулю");
    // Process.GetCurrentProcess().Kill();
}
else
{
    Console.WriteLine("Введите Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (y == 0)
    {
        Console.WriteLine("Ошибка - Y не должен быть равен нулю");
        Environment.Exit(0);
    }
    else
    {
        if ((x > 0) && (y > 0))
        {
            Console.WriteLine("Точка находтся в I четверти");
        }
        else if ((x < 0) && (y > 0))
        {
            Console.WriteLine("Точка находтся в II четверти");
        }
        else if ((x < 0) && (y < 0))
        {
            Console.WriteLine("Точка находтся в III четверти");
        }
        else
        {
            Console.WriteLine("Точка находтся в IV четверти");
        }
    }
}
