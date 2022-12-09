// Задача 58: Задайте две матрицы. Напишите программу, которая
//  будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rowsA = InputInitialData("Введите число строк матрицы A: ");
int value = InputInitialData("Введите число столбцов матрицы A = числу строк матрицы B: ");
int columnsB = InputInitialData("Введите число столбцов матрицы B: ");
int range = InputInitialData("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[rowsA, value];
FillMatrix(firstMartrix);
Console.WriteLine("Матрица A:");
PrintMatrix(firstMartrix);

int[,] secondMartrix = new int[value, columnsB];
FillMatrix(secondMartrix);
Console.WriteLine("Матрица В:");
PrintMatrix(secondMartrix);

int[,] resultMatrix = new int[rowsA, columnsB];

GetMultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine("Произведение матриц:");
PrintMatrix(resultMatrix);

void GetMultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputInitialData(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}
