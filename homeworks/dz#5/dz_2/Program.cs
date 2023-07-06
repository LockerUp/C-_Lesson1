// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] arr = FillArray();
System.Console.WriteLine($"[{String.Join(", ", arr)}] -> {SummElements(arr)}");

int[] FillArray()
{
    int size = new Random().Next(2,10);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}

int SummElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        sum += array[i];
    }
    return sum;
}