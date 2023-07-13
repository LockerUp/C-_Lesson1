// **Задача 40:**Напишите программу,
// которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
System.Console.WriteLine("Введите первое число");
int value1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int value2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int value3 = int.Parse(Console.ReadLine());
method(value1, value2, value3);


void method(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))
        System.Console.WriteLine("Треугольник существовать");
    else
        System.Console.WriteLine("Треугольник не существует");
}