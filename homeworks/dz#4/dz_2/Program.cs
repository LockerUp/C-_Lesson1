// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
System.Console.WriteLine("Введите число");
int value = int.Parse(Console.ReadLine());
System.Console.WriteLine(summ(value));

int summ(int n) 
{
    int i = 0;
    int sum = 0;
    while (value > 0) {
       sum += value%10;
       value /= 10;
       i++;

    }

    return sum;
}