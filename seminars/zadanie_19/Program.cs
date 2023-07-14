// Задайте двумерный массив. Найдите элементы, у которых оба индека нечётные, и замените эти элементы на их квадраты.

Console.Clear();

System.Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] myMatrix = FillMatrix(m, n);
PrintMatrix(myMatrix);
QuatroMatrix(myMatrix);
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


void QuatroMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                matr[i, j] *= matr[i,j]; 
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