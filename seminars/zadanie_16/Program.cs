/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

Console.Clear();
System.Console.WriteLine("Введите число:");
int value = int.Parse(Console.ReadLine());


System.Console.WriteLine(string.Join(" ", Fibonacci(value)));

int[] Fibonacci(int value)
{
    int[] arr = new int[value];
    for (int i = 1; i < value; i++)
    {
        if (i > 1)
            arr[i] = arr[i - 1] + arr[i - 2];
        else
            arr[i]++;
    }
    return arr;
}