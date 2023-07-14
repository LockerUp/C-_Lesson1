// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

System.Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] myMatrix = FillMatrix(m, n);
PrintMatrix(myMatrix);
SummOfColumns(myMatrix, m, n);

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(11);
        }
    }
    return matrix;
}


void SummOfColumns(int[,] matr, int m, int n)
{
    for (int j = 0; j < n; j++)
    {
        double arifm = 0;
        for (int i = 0; i < m; i++)
        {
           arifm += matr[i,j];
        }
        System.Console.Write(Math.Round(arifm/m,1) + "\t");
    }
}


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}