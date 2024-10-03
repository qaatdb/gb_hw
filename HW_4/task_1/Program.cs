// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа
// с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//Метод int.TryParse(string s, out int result) проверяет, можно ли получить число из строки.
//Если это возможно - возвращает true и полученное число out-параметром,
//иначе возвращает false результатом и default(int) out-параметром.

// void InputNumberInCicle()
// {
//     Console.WriteLine("Введите число: ");
//     InputNumber();
// }

// void InputNumber()
// {
//     string input = Console.ReadLine();
//     if (int.TryParse(input, out int i))
//     {
//         int inputNum = Int32.Parse(input);
//         if (!CheckNumberEven(inputNum))
//         {
//             InputNumberInCicle();
//         }
//         else
//         {
//             Console.WriteLine("Осуществлен выход из программы");
//         }
//         //InputNumberInCicle();
//     }
//     else if (CheckQ(input))
//     {
//         Console.WriteLine("Осуществлен выход из программы");
//     }
//     else
//     {
//         Console.WriteLine("Ошибка");
//     }
// }

bool CheckNumberEven(int input)
{
    int sum = 0;
    while (input < 0)
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


//InputNumber();

// string test = "w";
// if (CheckQ(test)) {
//     Console.WriteLine("yes");
// }
// else{
//  Console.WriteLine("nu-uuuh");   
// }




// int test = 120;
// if (CheckNumberEven(test)) {
//     Console.WriteLine("yes");
// }
// else{
//  Console.WriteLine("nu-uuuh");   
// }

// Console.WriteLine("Введите число: ");
// InputNumber();


int input = 120;
int sum = 0;
while (input != 0)
{
    sum += input % 10;
    Console.WriteLine(sum);
    input = input / 10;
    Console.WriteLine(input);
}
Console.WriteLine(sum);