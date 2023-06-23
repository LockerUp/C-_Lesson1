// 7.Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает **последнюю** цифру этого числа.
    
//     456 -> 6
    
//     782 -> 2
    
//     918 -> 8

Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int value = int.Parse(Console.ReadLine());

int itog = value % 10;
Console.WriteLine($"{value} -> " + itog);
