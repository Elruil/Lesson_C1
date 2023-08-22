//Задача 32: Напишите программу замены элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int ArraySize = GetNumberFromUser("Введите целое число для определения длины массива", "Ошибка ввода");
int ArrayMin = GetNumberFromUser("Введите целое число для определения нижней границы рандомного значения", "Ошибка ввода");
int ArrayMax = GetNumberFromUser("Введите целое число для определения верхней границы рандомного значения", "Ошибка ввода");
int[] Array = GetArray(ArraySize, ArrayMin, ArrayMax);
SetLineArray(Array);
GetReversArray(Array);
Console.WriteLine("");
SetLineArray(Array);
Console.WriteLine("");
int number = GetNumberFromUser("Введите число для поиска в массиве","Ошибка ввода");
bool result = FindNumber(number, Array);
Console.WriteLine($"заданное число {number} -> {(result ? "да" : "нет")} ");

int GetNumberFromUser(string Message, string errorMessage)
{

    while (true)
    {
        Console.WriteLine(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int low, int high)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(low, high + 1);
    }
    return arr;
}

void SetLineArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($" {arr[i]}, ");
        else
            Console.Write($" {arr[i]}.");
    }
    Console.Write("]");
}

int[] GetReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

bool FindNumber(int num ,int[] arr)
{
    foreach (int el in arr)   
    {   
        if (el == num) return true;
    }   
    return false;
}