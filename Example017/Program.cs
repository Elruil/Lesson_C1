Console.Clear();
//Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.

int FiveDigitNum = GetFiveDigitNum("Введите пятизначное число", "Ошибка ввода данных!", "Вы ввели не пятизначное число");
CheckNum(FiveDigitNum, "Палиндромом является введенное число ", "Не является палиндромом введенное число ");

static void CheckNum(int Num, string Message, string ErMessage)
{
    int NumOne = Num / 10000;
    int NumTwo = (Num / 1000) % 10;
    int NumFour = (Num / 10) % 10;
    int NumFive = Num % 10;
    if (NumOne == NumFive && NumTwo == NumFour)
        Console.WriteLine($"{Num}  {Message}");
    else
        Console.WriteLine($"{Num} {ErMessage}");
}

static int GetFiveDigitNum(string Message, string errorMessage, string ErrorEnter)
{
    while (true)
    {
        try
        {
            Console.WriteLine(Message);
            int num = int.Parse(Console.ReadLine() ?? "");
            if (num > 9999 && num < 1000002)
                return num;
            else Console.WriteLine(ErrorEnter);
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");
        }
    }
}
