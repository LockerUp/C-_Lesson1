//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле Amn = m+n. Выведите полученный массив на экран.

Console.Clear();

System.Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] myMatrix = FillArray(m, n);
PrintMatrix(myMatrix);