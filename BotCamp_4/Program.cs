Console.Clear();

Console.WriteLine("Введите число элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число элементов массива {size}");
int[] Array = new int[size];
for (int i = 0; i < size; i++)
{
    Array[i] = new Random().Next(-20, 21);
}
Console.WriteLine($"Полученный массив - [{String.Join(' ', Array)}]");
SortVibor(Array);
Console.WriteLine($"Полученный массив - [{String.Join(' ', Array)}]");
int[] SortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int IndexMin = i;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < array[IndexMin])
            {
                IndexMin = j;
            }
            if (array[IndexMin] == array[i])
                continue;

            int temp = array[i];
            array[i] = array[IndexMin];
            array[IndexMin] = temp;
        }

    }
    return array;
}