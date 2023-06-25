// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Random random = new Random();
int firstValue = random.Next(100);
int secondValue = random.Next(100);
int thirstValue = random.Next(100);
Console.Write($"{firstValue}, {secondValue}, {thirstValue} -> ");

int max = 0;
if (firstValue > secondValue) {
    max = firstValue;
} if (secondValue > max) {
    max = secondValue;
} if (thirstValue > max) {
    max = thirstValue;
}

Console.Write(max);