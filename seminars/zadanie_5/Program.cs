// 20 Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

System.Console.WriteLine("Введите координаты первой точки");
System.Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты второй точки");
System.Console.Write("Введите координату x: ");
int x1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y: ");
int y1 = int.Parse(Console.ReadLine());

double a = Math.Sqrt(Math.Pow((x-x1),2) + Math.Pow((y-y1),2));

System.Console.WriteLine($"{a:f2}");