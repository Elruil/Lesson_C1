//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

Console.Clear();

int Number = GetNumberFromUser("Введите целое число", "Ошибка ввода");

Console.WriteLine($"Введенное число {Number}");
int[] BinaryArray = GetBinary(Number);
Console.WriteLine(String.Join(" ", BinaryArray));
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

int[] GetBinary(int Num)
{
    int i = 0;
    int size = Num;
    while(size > 0)
    {  
       size = size/2;
       i++;
    }
   
    int[] arr = new int[i];
    int j = arr.Length - 1;
    while ( Num > 0 )
    {
        arr[j] = Num%2;
        Num = Num/2;
        j--;
    }
    return arr;
}