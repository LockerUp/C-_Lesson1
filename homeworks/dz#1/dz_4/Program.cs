// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Random random= new Random();

int value = random.Next(-100,100);

if (value % 2 >= 1) {
    Console.WriteLine("Число " + value + " нечётное");
} else {
    Console.WriteLine("Число " + value + " чётное");
}