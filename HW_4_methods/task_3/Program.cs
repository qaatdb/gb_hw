// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] FillArrayByUser(int arrayLenght){
    Console.WriteLine("Введите элементы массива: ");
    int [] array = new int[arrayLenght];
    for (int i = 0; i < arrayLenght; i ++) {
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int[] ConvertArray(int[] array){
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++){
        temp = array[array.Length - i - 1];
        array[array.Length - i - 1] = array[i];
        array[i] = temp;
    }  
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0)
{
    Console.WriteLine("Ошибка. Размер массива не может быть отрицательным");
    Environment.Exit(0);
}
int[] arr = FillArrayByUser(size);
PrintArray(arr);

int[] newArr = ConvertArray(arr);
Console.WriteLine("\nПеревернутый массив: ");
PrintArray(newArr);


