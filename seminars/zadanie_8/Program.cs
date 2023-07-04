//28 Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

Console.Clear();
System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int itog(int n) {
    int i = 1;
    int itog = 1;
    while (i <= n){
        itog *= i;
        i++;
    }
    return itog;
}

System.Console.WriteLine(itog(n));