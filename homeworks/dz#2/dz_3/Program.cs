// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите порядковый номер дня недели");
int day = int.Parse(Console.ReadLine());
 if (day < 1 || day > 7) {
    System.Console.WriteLine("Такого дня недели нет");
 } else {
    if (day == 6 || day == 7) {
        System.Console.WriteLine($"{day} -> да");
    } else {
        System.Console.WriteLine($"{day} -> нет");
    }
 }