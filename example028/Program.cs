//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
int num = GetNumberFromUser("Введите целое число", "Ошибка ввода");
int multiplication = GetMultiplication(num);
Console.WriteLine($"{num} -> {multiplication}");

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

int GetMultiplication(int num)
{
    int multiplication = 1;
    while (num > 1)
    {
        multiplication = multiplication*num;
        num--;
    }
    return multiplication;
}