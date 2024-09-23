// Напишите метод, который на вход принимает число (number),
// а на выходе выводит все нечетные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

using System;
public class Answer
{
    static void PrintOddNumbers(int number)
    {
        int count = 1;
        while (count <= number)
        {
            if (count % 2 != 0)
            {
                Console.Write(count + " ");
            }
            count++;
        }
    }
    static public void Main(string[] args)
    {
        int number;
        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
            }
        else {
            // number = 5;
            number = 19;
            }
        PrintOddNumbers(number);
    }
}