// Описание: Задайте двумерный массив целых чисел.
// Напишите программу, которая находит максимальный элемент в каждой строке массива и выводит его.


void FindMaxInRows(int[,] matrix) {
    int maxInRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > maxInRow) {
                maxInRow = matrix[i, j];
            }
        }
        Console.Write($"Максимальный элемент в строке {i} - {maxInRow}\n");
    }
}

int[,] array = {{ 1, 10,  5,  7},
                { 2, 40,  6,  8},
                { 9, 10, 11, 112}};

FindMaxInRows(array);
