//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
//int[] Array = GetArray(8, 0, 2);
int ArraySize = GetNumberFromUser("Введите целое число для определения длины массива", "Ошибка ввода");
int ArrayMin = GetNumberFromUser("Введите целое число для определения нижней границы рандомного значения", "Ошибка ввода");
int ArrayMax = GetNumberFromUser("Введите целое число для определения верхней границы рандомного значения", "Ошибка ввода");
int[] Array = GetArray(ArraySize, ArrayMin, ArrayMax);
SetLineArray(Array);

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
//SetLineArray(GetArray(GetNumberFromUser("Введите целое число для определения длины массива", "Ошибка ввода"), GetNumberFromUser("Введите целое число для определения нижней границы рандомного значения", "Ошибка ввода"), GetNumberFromUser("Введите целое число для определения верхней границы рандомного значения, Помните что число будет меньше на единицу", "Ошибка ввода")));