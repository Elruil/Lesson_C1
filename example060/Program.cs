//Задача 60: Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно выводить
//массив, добавляя индексы каждого элемента.

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество элементов по третьей оси  массива ");
int line = int.Parse(Console.ReadLine() ?? "");
int[,,] Array = GetArray(rows, columns, line, 0, 10);
Console.WriteLine($"{rows}  {columns}");
Console.WriteLine("");
PrintArray(Array);


int[,,] GetArray(int m, int n, int l, int Min, int Max)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = new Random().Next(Min, Max + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент с индексом [{i},{j},{k}] - > {arr[i, j, k]}");
            }
        }
    }
}


