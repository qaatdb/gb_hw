// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

void printArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

string makeStringFromArray(char[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }
    return result;
}

char[,] arrayOfChar = new char[,] {{'a', 'b', 'c', 'd',},
                             {'7', 't', 's', '@',}};
printArray(arrayOfChar);
Console.WriteLine($"Результат преобразования в строку: {makeStringFromArray(arrayOfChar)}");