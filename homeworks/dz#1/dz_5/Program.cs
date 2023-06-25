// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Random random= new Random();

int value = random.Next(1, 20);
Console.Write(value + " -> ");
 for (int i = 1; i <= value; i++)
    if (i % 2 < 1) {
        Console.Write(i + ", ");
    }