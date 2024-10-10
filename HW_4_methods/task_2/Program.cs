// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int arrayLenght, int lowerLimit, int upperLimit)
{
    int[] array = new int[arrayLenght];
    Random rnd = new Random();
    for (int i = 0; i < arrayLenght; i++)
    {
        array[i] = rnd.Next(lowerLimit, upperLimit);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountEvenNumbers(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0)
{
    Console.WriteLine("Ошибка. Размер массива не может быть отрицательным");
    Environment.Exit(0);
}

Console.WriteLine("Введите нижнюю границу значений элементов массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу значений элементов массива: ");
int max = Convert.ToInt32(Console.ReadLine());
if (((99 < min && min > 999) && (99 < max && max > 999)) || ((-999 < min && min > -99) && (-999 < max && max > -99)))
{
    Console.WriteLine("Ошибка. Необходимо ввести трехзначные числа при выборе нижней и верхней границ.\nЭлементы массива должны быть трехзначными");
    Environment.Exit(0);
}
if ((min > 0 && min > max) || (min < 0 && max < min)) {
    Console.WriteLine("Ошибка. Нижняя граница должна быть меньше верхней.");
    Environment.Exit(0);   
}

int[] arr = FillArray(size, min, max);
PrintArray(arr);
Console.WriteLine($"\nКоличество четных чисел в массиве: {CountEvenNumbers(arr)}");