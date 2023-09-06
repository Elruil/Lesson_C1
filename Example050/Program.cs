//Задача 50: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] Array = GetArray(rows, columns, 0, 10);
Console.WriteLine($"{rows}  {columns}");
PrintArray(Array);
Console.Write("Введите  строку расположения элемента ");
int userRows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите столбец расположения элемента ");
int userColumns = int.Parse(Console.ReadLine() ?? "");
GetUnswer(Array, userRows, userColumns);

void GetUnswer(int[,] Arr, int UserNumber1, int UserNumber2)
{
    if (UserNumber1 > Arr.GetLength(0) || UserNumber2 > Arr.GetLength(1))
    { Console.WriteLine($"Элемента [{UserNumber1},{UserNumber2}] нет в массвиве"); }
    else
    {
        int result = Arr[UserNumber1, UserNumber2];
        Console.WriteLine($"Элемент [{UserNumber1},{UserNumber2}] равен {result}");
    }

}


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



