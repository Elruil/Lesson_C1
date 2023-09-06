
//Задача 47: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами


Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
double[,] Array = GetArray(rows, columns);
Console.WriteLine($"{rows}  {columns}");
PrintArray(Array);

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for(int i = 0; i < m;i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble() * 100 - 50;
        }
    }
    return result;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0;j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]:f3} ");
        }
        Console.WriteLine();

    }
}




