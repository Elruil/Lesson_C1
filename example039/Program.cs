//Задача 39: Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
Console.Clear();
int ArraySize = GetNumberFromUser("Введите число элементов массива", "Ошибка ввода");
int min = GetNumberFromUser("Введите миниальное значение для элементов массива", "Ошибка ввода");
int maxFromUser = GetNumberFromUser("Введите максимальное  значение для элементов массива", "Ошибка ввода");
int max = maxFromUser + 1;
Console.WriteLine($"заданный пользователем размер массива - {ArraySize}, минимальное значение - {min}, максимальное значение - {maxFromUser}");
int[] Array = GetArray(ArraySize, min, max);
SetLineArray(Array);
int[] reversArray = reversArray1(Array);
Console.WriteLine();
SetLineArray(reversArray);
/*Console.WriteLine(String.Join(" ", reversArray));*/
ReversArray2(Array);
Console.WriteLine();
/*Console.WriteLine(string.Join(" ", Array));*/
SetLineArray(Array);

int GetNumberFromUser(string Message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int SizeFromUser);
        if (isCorrect)
        {
            return SizeFromUser;
        }
        Console.WriteLine(errorMessage);
    }
}

static int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
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

int[] reversArray1(int[] arr)
{
    int[] array = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        array[i] = arr[arr.Length - i - 1]; 
    }
    return array;
}

void ReversArray2(int[] arr)
{
      for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }


}

