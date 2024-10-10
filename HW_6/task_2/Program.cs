// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


// https://learn.microsoft.com/ru-ru/dotnet/api/system.char.islower?view=net-8.0
// https://learn.microsoft.com/ru-ru/dotnet/api/system.char.isupper?view=net-8.0
// https://learn.microsoft.com/ru-ru/dotnet/api/system.char.tolower?view=net-8.0

string makeNewStringInLowercase(string s)
{
    string result = string.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        if (Char.IsUpper(s[i]))
        {
            result += Char.ToLower(s[i]);
        }
        else
        {
            result += s[i];
        }
    }
    return result;
}

Console.WriteLine("Введите строку из латинских букв: ");
string input = Convert.ToString(Console.ReadLine());

// // Простое решение
// input = input.ToLower();
// Console.WriteLine($"Результат преобразований: {input}");

input = makeNewStringInLowercase(input);
Console.WriteLine($"Результат преобразований: {input}");