// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.

Console.Clear();
WriteNumbers(ReadInt("Введите число: "));

int ReadInt(string prompt)
{
    System.Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num)
{
    if (num == 0) return;
    WriteNumbers(num - 1);
    System.Console.Write(num + " ");
}