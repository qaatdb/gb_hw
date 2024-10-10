// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

// Метод String.Split создает массив подстрок, разбивая входную строку по одному или нескольким разделителям.
// Этот метод зачастую является самым простым способом разделить строку по границам слов.
// Он также используется для разбиения строк по другим конкретным символам или строкам.

// https://learn.microsoft.com/ru-ru/dotnet/csharp/how-to/parse-strings-using-split

string reverseString(string s)
{
    string result = string.Empty;
    string[] words = s.Split(' ');
    for (int i = words.Length - 1; i >= 0; i--)
    {
        result = result + words[i] + " ";
    }
    return result;
}

Console.WriteLine("Введите строку: ");
string input = Convert.ToString(Console.ReadLine());
if (!input.Contains(' '))
{
    Console.WriteLine("Строка не содержит пробел");
    Environment.Exit(0);
}

Console.WriteLine($"Результат преобразований: {reverseString(input)}");