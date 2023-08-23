//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
Console.Clear();

int[] Array = GetArray(6, 0, 10);
int Quantity = GetQuantity(Array,9,100);
Console.WriteLine($"массив {String.Join(" ", Array)}");
Console.WriteLine($"Количество элементов массива в промежутке [10,90] -> {Quantity}");
int[] newArray = GetMultiplication(Array);
Console.WriteLine($"полученный массив {String.Join(" ", newArray)}");
int[] GetArray(int size, int lowValue, int highValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(lowValue, highValue);
    }
    return arr;
}
int GetQuantity(int[] arr,int minValue, int maxValue)
{   
    int Quan = 0;
    foreach(int el in arr)
    {
   
    if (el > minValue && el < maxValue )
    {
        Quan++;
    }

    }
return Quan;
}
int[] GetMultiplication(int[] arr)
{   int size = arr.Length/2;
    int s = arr.Length -1;
    int[] newarr = new int[size];
   
    for(int i = 0; i < size; i++)
    
    {
        
        
        newarr[i] = arr[i] * arr[s];
        s--;
        
    }
    return newarr;
}
