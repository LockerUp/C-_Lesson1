System.Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine());

if (number == 1) {
    System.Console.WriteLine("Диапазон в 1 четверти: x > 0, y > 0");
} if (number == 2) {
    System.Console.WriteLine("Диапазон в 2 четверти: x < 0, y > 0");
} if (number == 3) {
    System.Console.WriteLine("Диапазон в 3 четверти: x < 0, y < 0");
} if (number == 4) {
    System.Console.WriteLine("Диапазон в 4 четверти: x > 0, y < 0");
} if (number < 1 || number > 4) {
    System.Console.WriteLine("такой четверти нет");
}