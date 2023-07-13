// **Задача 42:**Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

Console.Clear();

System.Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());

int[] arr = ConvertToBinary(value, Count(value));

ReverseArray(arr, Count(value)); 
System.Console.WriteLine(string.Join("", arr));

int Count(int value)
{
    int i = 0;
    while (value > 0)
    {
        value /= 2;
        i++;
    }
    return i;
}

int[] ConvertToBinary(int value, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = value % 2;
        value /= 2;
    }
    return array;
}

void ReverseArray(int[] arr, int size)
{
    for (int i = 0; i < size/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[size-1-i];
        arr[size-1-i] = temp;
    }
}