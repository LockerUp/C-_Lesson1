//Перемножение двух матриц

Console.Clear();

System.Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] firstMatrix = FillMatrix(m, n);
int[,] secondMatrix = FillMatrix(m, n);
int[,] itogMatrix = ItogoMatrix(firstMatrix, secondMatrix, m, n);



for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        Console.Write(firstMatrix[i, j] + "\t");
    }
    if (i == firstMatrix.GetLength(0) / 2)
        Console.Write("*" + "\t");
    else
        Console.Write(" "+ "\t");

    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        Console.Write(secondMatrix[i, j] + "\t");
    }
    if (i == secondMatrix.GetLength(0) / 2)
        Console.Write("=" + "\t");
    else
        Console.Write(" "+ "\t");

    for (int j = 0; j < itogMatrix.GetLength(1); j++)
    {
        Console.Write(+itogMatrix[i, j] + "\t");
    }
    System.Console.WriteLine();

}

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


int[,] ItogoMatrix(int[,] matr1, int[,] matr2, int m, int n)
{
    int[,] matr3 = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr3[i, j] = matr1[i, j] * matr2[i, j];
        }
    }
    return matr3;
}


// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < firstMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < firstMatrix.GetLength(1); j++)
//     {
//         Console.Write(firstMatrix[i, j] + "\t");
//     }
//     if (i == firstMatrix.GetLength(0) / 2)
//         Console.Write("\t" + "=" + "\t");
//     else
//         Console.Write("\t" +" "+ "\t");

//     for (int j = 0; j < secondMatrix.GetLength(1); j++)
//     {
//         Console.Write(secondMatrix[i, j] + "\t");
//     }
//     if (i == secondMatrix.GetLength(0) / 2)
//         Console.Write("\t" + "=" + "\t");
//     else
//         Console.Write("\t" +" "+ "\t");

//     for (int j = 0; j < itogMatrix.GetLength(1); j++)
//     {
//         Console.Write(+itogMatrix[i, j] + "\t");
//     }
//     System.Console.WriteLine();

// }
// }