// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] array = CreateMatrix();
int[,] array1 = CreateMatrix();
int[,] array3 = ProizvMatrix(array, array1);

PrintMatrix(array);
System.Console.WriteLine();
PrintMatrix(array1);
System.Console.WriteLine();
PrintMatrix(array3);



int[,] CreateMatrix()
{
    int[,] matrix = new int[3, 3];
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

int[,] ProizvMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            matr3[i, j] = 0;
            for (int k = 0; k < matr3.GetLength(1); k++)
            {
                matr3[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return matr3;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}