// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] arrey = FillArray();
System.Console.WriteLine($"[{String.Join(", ", arrey)}] -> " + EvenNumbers(arrey));



int[] FillArray()
{
    int size = new Random().Next(2,10);
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}