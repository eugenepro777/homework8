// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей
//  суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите число строк:\t");
int initialRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов:\t");
int initialColumns = Convert.ToInt32(Console.ReadLine());

var fillMatrix = FillMatrix(initialRows, initialColumns);
PrintMatrix(fillMatrix);
Console.WriteLine();

Console.Write("Сумма по строкам: ");
PrintArray(FindSumElements(fillMatrix, initialRows));

FindMaxInRows(FindSumElements(fillMatrix, initialRows));

void FindMaxInRows(int[] array)
{
    int minSum = array[0];
    int numberMinSumRow = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            numberMinSumRow = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberMinSumRow + 1} строка");
}

int[] FindSumElements(int[,] matrix, int row)
{
    int[] sumRow = new int[row];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
    }
    return sumRow;
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.WriteLine($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}
