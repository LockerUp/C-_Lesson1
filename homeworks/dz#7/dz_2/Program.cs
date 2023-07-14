// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();

System.Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
System.Console.Write("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());


int[,] myMatrix = CreateAndFillRandomMatrix();
PrintMatrix(myMatrix);
ElemOfMatrix(myMatrix, row, column);

int[,] CreateAndFillRandomMatrix()
{
    Random random = new Random();
    int m = random.Next(1,5);
    int n = random.Next(1,5);

    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(11);
        }
    }
    return matrix;
}

void ElemOfMatrix(int[,] matr, int i, int j)
{
    if (i < matr.GetLength(0) && j < matr.GetLength(1))
    System.Console.WriteLine(matr[i,j]);
    else
    System.Console.WriteLine("Число в этой ячейке не найдено");
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