// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа
// с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void AskForInput()
{
    Console.WriteLine("Введите число: ");
    InputNumber(); //вызываем функцию ввода числа
}

void InputNumber()
{
    string input = Console.ReadLine(); //читаем, что ввел пользователь
    //Метод int.TryParse(string s, out int result) проверяет, можно ли получить число из строки.
    //Если это возможно - возвращает true и полученное число out-параметром,
    //иначе возвращает false результатом и default(int) out-параметром.
    if (int.TryParse(input, out int i)) //если ввод - число 
    {
        int inputNum = Int32.Parse(input); //в новую переменную записываем это число
        if (!CheckNumberEven(inputNum)) //проверяем на условие, что сумма цифр - нечетная
        {
            AskForInput(); //бесконечно друг друга дергают функции для вызова
                            // друг друга, пока не будет выполнено одно из условий завершения работы программы
        }
        else
        {
            Console.WriteLine("Осуществлен выход из программы");
        }
    }
    else if (CheckQ(input)) //проверяем, что ввод в консоль - это q
    {
        Console.WriteLine("Осуществлен выход из программы");
    }
    else //это если пользователь вводит фигню
    {
        Console.WriteLine("Ошибка, попробуйте еще раз ввести число.\n Для выхода из программы нажмите q");
        AskForInput();
    }
}

bool CheckNumberEven(int input)
{
    int sum = 0;
    while (input != 0)
    {
        sum += input % 10;
        input = input / 10;
    }
    if (sum % 2 == 0)
    {
        return true;
    }
    return false;
}

bool CheckQ(string input)
{
    input = Convert.ToString(input);
    string str = "q";
    return (input.Equals(str));
}

AskForInput(); //начало работы - переход к функции печати на экран просьбы ввести что-то