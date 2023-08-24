//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным
//элементов массива.
Console.Clear();

/*Console.WriteLine("Задайте размер будущего массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Полученный массив вещественных чисел: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}

Console.WriteLine($"Массив содержит {numbers.Length} чисел. Максимальное значение раено {max}, минимальное значение равно {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением равна {max - min}");

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
*/
Console.Clear();
double[] Array = GetArray(10);
Console.WriteLine($"Полученный массив {String.Join(" ",Array)}");
double numberMax = GetNumberMax(Array);
Console.WriteLine($"Максимально число {numberMax}");
double numberMin = GetNumberMin(Array);
Console.WriteLine($"Минимальное число {numberMin}");
double difference = numberMax - numberMin;
Console.WriteLine($"Рахница между максимальным и минимальным числом равна  {difference}");
double[] GetArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size ; i++)
    {
        arr[i] = new Random().NextDouble()*100;
    }    
    return arr;
}
double GetNumberMax(double[] arr)
{
    double max = 0;
    foreach(double el in arr)
    {
        if (el > max)
        {max = el;}
    }
    return max;
} 
double GetNumberMin(double[] arr)
{
    double min = arr[0];
    foreach (double el in arr)
    {
    if (el < min)
    {min = el;}
    }
    return min;
}