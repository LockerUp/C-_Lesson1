Console.WriteLine("Введите проверяемое число");
int num = int.Parse(Console.ReadLine());

if ((num % 7 == 0) && (num % 23 == 0)) {
    Console.WriteLine($"{num} -> да");
} else {
    Console.WriteLine($"{num} -> нет");
}