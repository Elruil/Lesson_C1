//Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] Array = GetArray(rows, columns, 0, 9);
Console.WriteLine($"{rows}  {columns}");
PrintArray(Array);
Console.WriteLine($"");
GetSortMaxMinOnLine(Array);
PrintArray(Array);

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

void GetSortMaxMinOnLine(int[,] Arr)
{
    int temp = 0;
    
    for(int i =  0; i < Arr.GetLength(0);i++)
    {
        
        for(int j = 1; j < Arr.GetLength(1);j++)
        {
            int k = j;
            while( k > 0 && Arr[i , k - 1] < Arr[i , k])
            {
                temp = Arr[i , k - 1];
                Arr[i , k - 1] = Arr[i , k];
                Arr[i , k] = temp;
                k -= 1;
            }
        }
    }
    
}