// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число");
int value = int.Parse(Console.ReadLine());

// int a = value/1000;
// System.Console.WriteLine(a);

if (value/10000 == value%10 && value/1000%10 == value%100/10){
    System.Console.WriteLine($"Число {value} -> полиндром");
    } else {
        System.Console.WriteLine($"Число {value} -> не полиндром");
    }