//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
int Number = GetNumberFromUser("Введите целое число для определения длины массива", "Ошибка ввода");
int[] Array = GetArray(Number, "Введите число для заполнения массива");

Console.WriteLine($"длина массива {Number}");
Console.WriteLine(String.Join(", ", Array));
int Quantity =  GetQuantityEvenNumbers(Array);
Console.WriteLine($" {Quantity} элемента массива больше нуля");

int GetQuantityEvenNumbers(int[] Arr)
{
    int i = 0;
    foreach (int el in Arr)
    {
    if (el > 0)
    i++;
    
    }
    return i;
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
