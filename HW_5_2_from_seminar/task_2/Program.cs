// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] fillMatrixWithNumbers(int rowsNum, int colsNum, int minNum, int maxNum)
{
    int[,] matrix = new int[rowsNum, colsNum];
    Random rnd = new Random();
    for (int i = 0; i < rowsNum; i++)
    {
        for (int j = 0; j < colsNum; j++)
        {
            matrix[i, j] = rnd.Next(minNum, maxNum);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

// An example of GetLength is GetLength(0), which returns the number of elements in the first dimension of the Array.
// GetLength(0) - первое измерение - строки?
// GetLength(1) - второе измерение - столбцы?

// Надо пройтись по столбцам только 
// элемент первой строки меняем с элементом последней строки

// Console.WriteLine($"{arr2d.GetLength(0)}"); //количество строк
// Console.WriteLine($"{arr2d.GetLength(1)}"); //количество столбцов


int[,] CreateNewMatrix(int[,] matrix)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++) // идем по столбцам
    {
        //меняем элемент первой строки на элемент последней строки
        temp = matrix[matrix.GetLength(0) - 1, j]; // последняя строка, первый столбец
        matrix[matrix.GetLength(0) - 1, j] = matrix[0, j];
        matrix[0, j] = temp;
    }
    return matrix;
}

Console.WriteLine("Введите количество строк в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
if (rows < 0)
{
    Console.WriteLine("Ошибка. Число не может быть отрицательным");
    Environment.Exit(0);
}
if (rows == 0)
{
    Console.WriteLine("Ошибка. Массив должен быть двумерным");
    Environment.Exit(0);
}

Console.WriteLine("Введите количество столбцов в двумерном массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());
if (cols < 0)
{
    Console.WriteLine("Ошибка. Число не может быть отрицательным");
    Environment.Exit(0);
}
if (cols == 0)
{
    Console.WriteLine("Ошибка. Массив должен быть двумерным");
    Environment.Exit(0);
}

Console.WriteLine("Введите нижнюю границу значений элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу значений элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());
if (min > max)
{
    Console.WriteLine("Ошибка. Нижняя граница должна быть меньше");
    Environment.Exit(0);
}

int[,] arr2d = fillMatrixWithNumbers(rows, cols, min, max);
Console.WriteLine("Полученный массив:");
printMatrix(arr2d);

// Console.WriteLine($"{arr2d.GetLength(0)}"); //количество строк
// Console.WriteLine($"{arr2d.GetLength(1)}"); //количество столбцов

Console.WriteLine("Новый массив:");
arr2d = CreateNewMatrix(arr2d);
printMatrix(arr2d);
