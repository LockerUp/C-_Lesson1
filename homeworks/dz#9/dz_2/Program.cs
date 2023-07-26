// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
System.Console.WriteLine(SumNumbers(ReadInt("Введие число M: "), ReadInt("Введие число N: ")));

int ReadInt(string prompt)
{
    System.Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m > n) return 0;
    return m + SumNumbers(m + 1, n);
}