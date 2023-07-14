//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали ( с индексами (0,0; (1;1) и т.д.)

Console.Clear();

System.Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] myMatrix = FillMatrix(m, n);
PrintMatrix(myMatrix);
SummMatrix(myMatrix);
PrintMatrix(myMatrix);

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(-10, 11);
        }
    }
    return matrix;
}

void SummMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i==j)
            matr[i,j] += matr[i,j];
        }
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