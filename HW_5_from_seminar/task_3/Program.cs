// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов

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
        Console.Write($" - строка № {i + 1}\n");
    }
}

void returnRowWhichSumIsMin(int[,] matrix){
    int sumMin = 0;
    int sum = 0;
    int indexOfMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            sum += matrix[i, j];
        }
        if (sum < sumMin) {
            sumMin = sum;
            indexOfMin = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов - № {indexOfMin + 1}");   
}

Console.WriteLine("Введите количество строк в прямоугольном двумерном массиве: ");
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

Console.WriteLine("Введите количество столбцов в прямоугольном двумерном массиве: ");
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
if (rows == cols)
{
    Console.WriteLine("Ошибка. Массив должен быть прямоугольным");
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
returnRowWhichSumIsMin(arr2d);