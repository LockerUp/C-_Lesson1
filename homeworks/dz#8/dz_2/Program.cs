// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] matr = CreateMatrix();
PrintMatrix(matr);
System.Console.WriteLine(string.Join(", ", MinSummOfRow(matr)));
int[] array = MinSummOfRow(matr);
System.Console.WriteLine("Строка с минимальной суммой: " + FindMinElem(array));


int[,] CreateMatrix()
{
    int[,] matrix = new int[6, 4];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 10);
        }
    }
    return matrix;
}


int[] MinSummOfRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}


int FindMinElem(int[] array)
{
    int min = array[0];
    int mini = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            mini = i;
        }
    }
    return mini;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}