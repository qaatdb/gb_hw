// Напишите метод, который принимает на вход три числа и возвращает среднее из этих чисел
// (то есть не самое большое и не самое маленькое).

using System;
public class Answer
{
static int FindMedian(int a, int b, int c){
       if ((a <= b) && (b <= c)) {
        return b;
       }
       else if ((a <= c) && (c <= b)) {
        return c;
       }
       else if((b <= a) && (a <= c)){
        return a;
       }
       else {
        return 0;
       }
    }
    static public void Main(string[] args)
    {
        int a, b, c;

        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            // a = 5;
            // b = 3;
            // c = 8;
            a = 7;
            b = 6;
            c = 10;
        }

        int result = FindMedian(a, b, c);
        Console.Write($"{result}");
    }
}