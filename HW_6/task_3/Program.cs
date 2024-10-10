// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool IsPalindrome(string s)
{
    bool result = false;
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] == s[s.Length - 1 - i])
        {
            result = true;
        }
        else
        {
            result = false;
        }
    }
    return result;
}

Console.WriteLine("Введите строку: ");
string input = Convert.ToString(Console.ReadLine());
if (IsPalindrome(input))
{
    Console.WriteLine("Введенная строка - палиндром");
}
else
{
    Console.WriteLine("Введенная строка - не палиндром");
}