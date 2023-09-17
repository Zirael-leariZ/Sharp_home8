// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int TheLowestString(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int minStringValue = int.MaxValue;
    int minStringPosition = -1;
    for (int i = 0; i < rows; i++ )
    {
        int currentStringSum = 0;
        for (int j = 0; j < columns; j++)
        { 
            currentStringSum =+ matrix[rows - 1 - i, columns - 1 - j];
        if (currentStringSum < minStringValue)
        {
            minStringValue = currentStringSum;
            minStringPosition = rows - 1 - i;
        }
        }
    }
    return minStringPosition;
}

int[,] newMatrix = FillMatrix(5, 4, 1, 10);
PrintMatrix(newMatrix);
Console.WriteLine();
int[,] matrix = newMatrix;
int result = TheLowestString(newMatrix);
Console.WriteLine($"String number {result + 1} is the lowest one");