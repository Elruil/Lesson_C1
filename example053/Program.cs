//Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] Array = GetArray(rows, columns, 0, 10);
Console.WriteLine($"{rows}  {columns}");
PrintArray(Array);
ChangeArrayLine(Array);
Console.WriteLine("");
PrintArray(Array);

int[,] GetArray(int m, int n, int Min, int Max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m;i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(Min, Max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0;j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();

    }
}

void ChangeArrayLine(int[,] Arr)
{
    
    for(int i = 0; i < 1; i++)
    {
        for(int j = 0; j < Arr.GetLength(1); j++)
        {
            int temp = 0;
            temp = Arr[i,j];
            Arr[i,j] = Arr[Arr.GetLength(0) - i - 1, j ];
            Arr[Arr.GetLength(0) - i - 1, j ] = temp;
        }
        
    }
    
}

