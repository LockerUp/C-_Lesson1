// Задайте значения M и N. Напишите программу, которая выведет все числа в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
WriteNumbers(ReadInt("Введие число M: "), ReadInt("Введие число N: "));

int ReadInt(string prompt)
{
    System.Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int m, int n)
{
    if (n == m - 1) return;
    WriteNumbers(m, n - 1);
    System.Console.Write(n + " ");
}