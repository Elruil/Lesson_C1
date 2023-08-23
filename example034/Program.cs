//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
/*
Console.Clear();

Console.WriteLine("Задайте размер будущего  массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Полученный массив из трехзначных чисел: ");
PrintArray(numbers);
int count = 0;

for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;

Console.WriteLine($"В массиве {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
/*Console.Clear();
int[] Array = GetArray(10, 1,10 );
int Result  = GetResult(Array);
int Sum = GetSumUn(Array);
Console.WriteLine($"Полученный массив {String.Join(" ",Array)}");
Console.WriteLine($"Количество четных чисел равно {Result}");
Console.WriteLine($"Сумма элементов на нечетных позициях {Sum}");
int[] GetArray(int size,int minValue,int maxValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}
int GetResult(int[] arr)
{
    int count = 0;
    foreach(int el in arr)
    {
        if(el%2 == 0)
        count++;
    }
    return count;
}  
int GetSumUn(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        if(i%2 != 0)
        {
        sum = sum + arr[i];
        }
    }
    return sum;
}  */
//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным
//элементов массива.
