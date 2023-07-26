// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

System.Console.WriteLine(SumOfNumbers(ReadInt("Введите число: ")));

int ReadInt(string prompt)
{
    System.Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumbers(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumOfNumbers(num / 10);
}