// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите число строк:\t");
int initialRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:\t");
int initialColumns = Convert.ToInt32(Console.ReadLine());

var fillMatrix = FillMatrix(initialRows, initialColumns);
PrintMatrix(fillMatrix);

GetSortMatrix(fillMatrix);
PrintMatrix(fillMatrix);

void GetSortMatrix(int[,] matrix)
{
    Console.WriteLine();
    int rowLength = matrix.GetLength(0);
    int columnLength = matrix.GetLength(1);
    
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < columnLength; j++)
        {
            for (int k = columnLength - 1; k > j; k--)            
                if (matrix[i, k] > matrix[i, k-1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k-1];
                    matrix[i, k-1] = temp;
                }
        }
    }

}

int[,] FillMatrix(int row, int column)
{
    var item = new Random();
    int rangeSize = 10;
    int lowerLimit = 1;

    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = item.Next(lowerLimit, rangeSize);
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
            Console.Write($"{(matrix[i, j])}  ");
        }
        Console.WriteLine();
    }
}
