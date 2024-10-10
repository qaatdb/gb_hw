// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет

void findElemInMatrix(int[,] matrix, int rowNumber, int colNumber){
    if (rowNumber <= matrix.GetLength(0) && colNumber <= matrix.GetLength(1)) {
        Console.WriteLine($"Значение элемента массива на строке {rowNumber} в столбце {colNumber} = {matrix[rowNumber,colNumber]}");
    } 
    else {
        Console.WriteLine("Элемента с указанными индексами нет в массиве");
    }
}

int[,] arr2d = {{4, 3, 1},
                {2, 6, 9}};

Console.WriteLine("Введите номер строки элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
if (row < 0) {
    Environment.Exit(0);
}

Console.WriteLine("Введите номер столбца элемента: ");
int col = Convert.ToInt32(Console.ReadLine());
if (col < 0) {
    Environment.Exit(0);
}

findElemInMatrix(arr2d, row, col);