//Задача 58: Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.
Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] ArrayOne = GetArray(rows, columns, 0, 10);
Console.Write("Введите количество строк массива ");
int row = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int column = int.Parse(Console.ReadLine() ?? "");
int[,] ArrayTwo = GetArray(row, column, 0, 10);

Console.WriteLine("");
PrintArray(ArrayOne);
Console.WriteLine("");
PrintArray(ArrayTwo);

int[,] Result = MultiplicationArray(ArrayOne, ArrayTwo);

Console.WriteLine("");
PrintArray(Result);


int[,] GetArray(int m, int n, int Min, int Max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(Min, Max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();

    }
}

static int[,] MultiplicationArray(int[,] ArrOne, int[,] ArrTwo)
{

    int[,] Result = new int[ArrOne.GetLength(0), ArrTwo.GetLength(1)];
    if (ArrOne.GetLength(1) == ArrTwo.GetLength(0))
    {
        for (int i = 0; i < Result.GetLength(0); i++)
        {
            for (int j = 0; j < Result.GetLength(1); j++)
            {
                Result[i, j] = 0;
                for (int n = 0; n < ArrOne.GetLength(1); n++)
                {
                    Result[i, j] += ArrOne[i, n] * ArrTwo[n, j];
                }
            }
        }
    }
    return Result;
}

