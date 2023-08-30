//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1./
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
int Number = GetNumberFromUser("Введите целое число", "Ошибка ввода");
int[] Array = GetFibbonachyArray(Number);
Console.WriteLine(String.Join( " ", Array));

int[] GetFibbonachyArray(int Num)
{
    if (Num <= 0) throw new Exception("Ошибка ввода");
    int[] Arr = new int[Num];
    Arr[0] = 0;
    if (Num == 1) return Arr;
    Arr[1] = 1;
   
    for (int i = 2; i < Arr.Length; i++)
    {
       
        Arr[i] = Arr[i - 1] + Arr[i - 2];
    }
    return Arr;
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
