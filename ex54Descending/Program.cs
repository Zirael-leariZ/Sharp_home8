// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillMatrix(int row, int columns, int min, int max)
{
    Random rand = new Random();
    int[,] dbArray = new int[row, columns];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dbArray[i, j] = rand.Next(min , max + 1);
        }
    }
    return dbArray;
}

static void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine();
    } 
}

static void Arrange(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
               if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }

    }
}
int[,] newMatrix = FillMatrix(4, 4, 1, 10);
PrintMatrix(newMatrix);
Console.WriteLine();
int[,] matrix = newMatrix;
Arrange(matrix);
PrintMatrix(matrix);
