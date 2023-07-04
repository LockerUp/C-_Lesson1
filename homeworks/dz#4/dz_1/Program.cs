// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
System.Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());


int method(int n) 
{   
    int i = 0;
    int itog = 1;
    while (i < b) {
        itog *= a;
        i++;
    }
    return itog;
}

System.Console.WriteLine(method(a));