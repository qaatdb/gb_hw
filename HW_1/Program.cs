// Напишите метод, который на вход принимает два целых числа и проверяет, делится ли первое число на второе.
// Если делится, выводите "делится", иначе выводите "не делится".

using System;

public class Answer{
    static void CheckDivisibility(int firstNumber, int secondNumber){
        if (secondNumber == 0){
            Console.Write("На ноль делить нельзя");
        }
        else if (firstNumber % secondNumber == 0){
            Console.Write("Первое число делится на второе");
        }
        else{
            Console.Write("Первое число не делится на второе");
        }
    }
    static public void Main(string[] args){
        int firstNumber, secondNumber;
        if (args.Length >=2){
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else {
            firstNumber = 10;
            secondNumber = 2;
            // firstNumber = 10;
            // secondNumber = 0;
        }

        CheckDivisibility(firstNumber, secondNumber);
    }
}