// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Random random = new Random();
int value = random.Next();
Console.WriteLine($"Введённое число = {value}");

if (value <= 99) {
    Console.WriteLine("Третьей цифры нет");
} else {
    while (value > 999) {
        value = value / 10;
    }
}

value = value%10;

Console.WriteLine($"третья цифра заданного числа = {value}");
