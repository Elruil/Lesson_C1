//Задача 56: Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] Array = GetArray(rows, columns, 0, 10);
Console.WriteLine($"{rows}  {columns}");
Console.WriteLine("");
PrintArray(Array);
Console.WriteLine("");
GetSum(Array);
GetMinLine(Array);

void  GetSum(int [,]Arr)
{
      
    for(int i = 0; i < Arr.GetLength(0);i++)
    {   
        int sum = 0;
        for(int j = 0; j < Arr.GetLength(1); j++)
        {
            sum = Arr[i,j] + sum;
        }
        
     Console.Write(sum + "; ");
    }
    
  
}

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

int SumLine(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

void GetMinLine(int[,]Array)
{
int minSum = 1;
int sum = SumLine(Array, 0);
for (int i = 1; i < Array.GetLength(0); i++)
{
if (sum > SumLine(Array, i))
{
sum = SumLine(Array, i);
minSum = i+1;
}
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
}
