//Задача 57: Составить частотный словарь элементов
//двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент
//входных данных

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] Array = GetArray(rows, columns, 0, 9);
Console.WriteLine($"{rows}  {columns}");
PrintArray(Array);
int Max = GetMaxInArray(Array);
Console.WriteLine($"Максимальный элемент в массиве {Max}");
int[] ArrayLine = ReversArrayInLine(Array);
Console.WriteLine(String.Join(", ", ArrayLine));
GetNumberMeet(ArrayLine);
//GetElementsInArray(Array);

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

//int[] GetElementsInArray(int[,] Arr)
//{
//   int[] result = new int[count];
//}

int GetMaxInArray(int[,] Arr)
{
    int max = 0;
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {

            if (Arr[i, j] > max)
            {
                max = Arr[i, j];
            }
        }
    }
    return max;
}

int[] ReversArrayInLine(int[,] Arr)
{
    int[] result = new int[Arr.GetLength(0) * Arr.GetLength(1)];
    int count = 0;
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {


            result[count] = Arr[i, j];
            count++;
        }

    }
    return result;
}

/*int[] GetUniqElements(int[] Arr)
{
    int[] result = new int[Arr.Length];
    for(int i = 0; i < Arr.Length; i++)
    {
        int temp = Arr[i];
        for(int j = 0; j < Arr.Length; j++)
        {
            if(Arr[j] == temp) continue
        }
    }
}
*/
void GetNumberMeet(int[] Arr)
{
    for (int i = 0; i < Arr.GetLength(0) ; i++)
    {
        int count = 0;
        for (int j = 0; j < Arr.GetLength(0); j++)
        {
            if (Arr[j] == Arr[i])
            {
                count++;
                
            }
            
        }
        Console.WriteLine($"{Arr[i]} - > {count} раз");
    }
}    