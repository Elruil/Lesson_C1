﻿//Задача 52: Задайте двумерный массив из целых чисел./
//Найдите среднее арифметическое элементов в каждом
//столбце.

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
GetArithmeticMean(Array);

void  GetArithmeticMean(int [,]Arr)
{
      
    for(int j = 0; j < Arr.GetLength(1);j++)
    {   
        double sum = 0;
        for(int i = 0; i < Arr.GetLength(0); i++)
        {
            sum = Arr[i,j] + sum;
        }
        sum = sum/Arr.GetLength(0);
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



