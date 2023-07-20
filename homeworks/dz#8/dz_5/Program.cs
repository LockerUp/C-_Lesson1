// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
System.Console.Write("Укажите количество строк матрицы: ");
int row = int.Parse(Console.ReadLine());
System.Console.Write("Укажите количество столбцов матрицы: ");
int col = int.Parse(Console.ReadLine());

int[,] matr = CreateAndFillMatrix(row, col);
PrintMatrix(matr);





int[,] CreateAndFillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int count = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = i; j < col - i; j++)
        {
            matrix[i, j] = count++;
        }

        for (int j = i + 1; j < row - i; j++)
        {
            matrix[j, col - 1 - i] = count++;
        }

        for (int j = col - 1 - i; j > i; j--)
        {
            matrix[row - 1 - i, j-1] = count++;
        }

        for (int j = row-1-i; j > i+1; j--)
        {
            matrix[j-1, i] = count++;
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
                System.Console.Write("0" + matrix[i, j] + "\t");
            else
                System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}