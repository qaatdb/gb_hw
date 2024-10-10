// Описание: Задайте двумерный массив. Замените все отрицательные числа на их абсолютные значения.

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

int[,] CreateNewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 0) {
                matrix[i,j] *= -1;
            }
        }
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
Console.WriteLine("Новый массив:");
arr2d = CreateNewMatrix(arr2d);
printMatrix(arr2d);