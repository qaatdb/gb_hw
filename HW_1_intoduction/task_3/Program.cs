// Напишите метод, который на вход принимает число и выводит, является ли оно положительным (больше нуля),
// отрицательным (меньше нуля) или нулём.

using System;
public class Answer
{
    static void CheckNumber(int number){
        if (number > 0){
            Console.Write("Число положительное");
        }
        else if (number == 0){
            Console.Write("Число равно нулю");   
        }
        else{
            Console.Write("Число отрицательное");   
        }
    }
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 7;
        }
        CheckNumber(number);
    }
}