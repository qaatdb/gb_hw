// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца. Используйте рекурсию и не используйте циклы.

void PrintArray(int[] arr, int i)
{
    Console.Write($"{arr[i]} ");
    if (i == 0) return;
    PrintArray(arr, i - 1);
}

int[] array = { 1, 2, 3, 4, 5, 6, 9 };
PrintArray(array, array.Length - 1);