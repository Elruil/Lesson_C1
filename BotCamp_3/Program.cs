/*int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число для {i} элемента массива");
    array[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"Полученный массив [ {String.Join(" , ", array)} ]");
Console.WriteLine(array[3]);
*/
 Console.WriteLine($"Введите число для определения количества элементов массива");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[n];
 for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число для {i} элемента массива");
    array[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"Полученный массив [ {String.Join(" , ", array)} ]");
int[,] arr = new int[n,n];
for(int i = 0; i < array.Length;i++)
{
    for (int j = 0; j < 1; j++)
    {
        arr[j,i] = array[i];
         arr[i,j] = array[i];
    }
}

for(int i = 1; i < arr.GetLength(0);i++)
{
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        arr[j,i] = arr[i - i,j] * arr[i ,j - j];
    }
        
    
}

PrintArray(arr);

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