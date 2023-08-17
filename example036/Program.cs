//Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
Console.Clear();

Console.WriteLine("Задайте размер будущего массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Полученный одномерный массив: ");
PrintArray(numbers);
int sum = 0;

for (int j = 0; j < numbers.Length; j+=2)
    sum = sum + numbers[j];

    Console.WriteLine($"массив содержит {numbers.Length} чисел, сумма нечетных элементов равна : {sum}");

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

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
