//Задача 62: Заполните спирально массив 4 на 4.


int size = 4;
int[,] Array = new int[size, size];
GetSpiralArray(Array, size);
PrintArray(Array);


void GetSpiralArray(int[,] array, int size)
{
    int i = 0;
    int j = 0;
    int count = 1;
    for (int z = 0; z < size * size; z++)
    {
        int l = 0;
        do { array[i, j++] = count++; }
        while (++l < size - 1);
        for (l = 0; l < size - 1; l++)
        { array[i++, j] = count++; }
        for (l = 0; l < size - 1; l++)
        { array[i, j--] = count++; }
        for (l = 0; l < size - 1; l++)
        { array[i--, j] = count++; }
        ++i;
        ++j;
        size = size < 2 ? 0 : size - 2;
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

