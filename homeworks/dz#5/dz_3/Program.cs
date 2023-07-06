// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
double[] arr = FillArray();
double itog = maxValue(arr) - minValue(arr);

System.Console.WriteLine($"[{String.Join(", ", arr)}] => {maxValue(arr)} - {minValue(arr)} = {itog}");


double[] FillArray()
{
    Random random = new Random();
    int size = random.Next(2,10);
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(121440, 14534213) / 10000.0;
    }
    return array;
}

double minValue(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        min = arr[i];
    }
    return min;
}

double maxValue(double[] arr)
{
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        max = arr[i];
    }
    return max;
}