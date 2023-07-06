/* **Задача 32:**Напишите программу замена элементов маccива:
положительные элементы замените на моответѝтвующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] String.Join(", ", array)*/

int[] GetRandomArray()
{
    int[] array = new int[4];
    for (int i = 0; i<array.Length; i++) 
    {
        array[i] = new Random().Next(2,10);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i<array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write("] - > [");

    for (int i = 0; i<array.Length; i++)
    {
        System.Console.Write($"{-array[i]}, ");
    }
    System.Console.Write("]");
}

PrintArray(GetRandomArray());

