// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты первой точки");
System.Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату z: ");
int z = int.Parse(Console.ReadLine());


System.Console.WriteLine("Введите координаты второй точки");
System.Console.Write("Введите координату x: ");
int x1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату y: ");
int y1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату z: ");
int z1 = int.Parse(Console.ReadLine());

double a = Math.Sqrt(Math.Pow((x-x1),2) + Math.Pow((y-y1),2) + Math.Pow((z-z1),2));

System.Console.WriteLine($"{a:f2}");