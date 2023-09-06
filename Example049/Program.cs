//Решение в группах задач:
//Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса нечётные, и замените эти элементы на их
//квадраты.

Console.Clear();

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] Array = GetArray(rows, columns, 0, 10);
Console.WriteLine($"{rows}  {columns}");
PrintArray(Array);
ChangeArray(Array);
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
int[,] ChangeArray(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
     for(int i = 0; i < arr.GetLength(0);i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           if (arr[i,j]%2 != 0)
           {arr[i,j] = arr[i,j] * arr[i,j];}
        }
    }
    return result;

}




