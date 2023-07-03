// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1, 4

System.Console.WriteLine("Введите число");
int value = int.Parse(Console.ReadLine());
double pow = 0;

for (int i = 1; i <= value; i++) {
    pow = Math.Pow(i,2);
    Console.Write($"{pow}, ");
}