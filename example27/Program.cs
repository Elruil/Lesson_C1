//Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
Console.Clear();
int num = GetNumberFromUser("Введите целое число", "Ошибка ввода");
int count = GetCountDigits(num);
Console.WriteLine($"{num} -> {count}");




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
int GetCountDigits(int num)
{
    int count = 0;
    while (num != 0)
        {
        int lastDigit = num%10;
        num = num/10;
        count += lastDigit;
    }  
    return count; 
} 