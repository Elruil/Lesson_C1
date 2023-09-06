//Задача 51: Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами
//(0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] Array = GetArray(rows, columns, 0, 10);
Console.WriteLine($"{rows}  {columns}");
PrintArray(Array);
int sum = GetSum(Array);
Console.WriteLine($"Ссума чисел по диагонали равно = {sum}");

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
int GetSum(int[,] arr)
{
    int result = 0;
    for(int i = 0; i < arr.GetLength(0);i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if ( i == j)
            {
                result = arr[i,j] + result;
            }
        }
    }
    return result;

}


