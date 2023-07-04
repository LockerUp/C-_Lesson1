// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int count(int n) {
    int i = 0;
    while (n != 0) {
        n /= 10;
        i++;
    }
    return i;
}

System.Console.WriteLine(count(number));