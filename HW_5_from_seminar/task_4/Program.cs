// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без строки и столбца

//using System.Diagnostics;

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

int[] SearchMinElementInMatrix(int[,] matrix)
{
    int minElem = 0;
    int rowMinElem = 0;
    int colMinElem = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElem){
                minElem = matrix[i, j];
                rowMinElem = i;
                colMinElem = j;
            }
        }
    }
    // Debug.WriteLine(rowMinElem);
    // Debug.WriteLine(colMinElem);
    return new int[]{rowMinElem, colMinElem};
}

int[,] DeleteCross(int[,] matrix, int[] coodinates)
{
    int coordinateRow = coodinates[0];
    int coordinateCol = coodinates[1];
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (i != coordinateRow)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                 (j != coordinateCol && result[i, j] != 0)
                {
                    result[i, j] = matrix[i, j];
                }
                else
                {
                    result[i, j] = matrix[i, j + 1];
                }
            }
        }
        else
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (j != coordinateCol && result[i, j] != 0)
                {
                    result[i, j] = matrix[i + 1, j];
                }
                else
                {
                    result[i, j] = matrix[i + 1, j + 1];
                }
            }
        }
    }
    return result;
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
// int[] arr = SearchMinElementInMatrix(arr2d);
// for (int i=0; i < arr.Length; i++){
//     Console.WriteLine(arr[i]);
// }
Console.WriteLine("Новый массив:");
int[,] newArr2d = DeleteCross(arr2d, SearchMinElementInMatrix(arr2d));
printMatrix(newArr2d);