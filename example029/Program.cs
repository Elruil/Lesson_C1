//Задача 29: Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.
Console.Clear();
int ArraySize = GetNumberFromUser("Введите целое число элементов массива", "Ошибка ввода");
int[] array = GetArray(ArraySize, "Ошибка ввода");
SetLineArray(array);
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
static int[] GetArray(int size,string errorMessage)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
      
        try
        {
            Console.WriteLine($"Введите {i} элемент массива");
            arr[i] = int.Parse(Console.ReadLine() ?? "");
        
           
        
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");
            i--;
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