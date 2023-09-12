//Задача 67: Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.Clear();
Console.WriteLine("Введите знаения числа ");
int Num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"{Num}");

int Sum = GetSum(Num);
Console.WriteLine($"{Sum}");
int GetSum(int N)
{
    if (N == 0) return 0;

    else return  N%10 + GetSum(N/10); //голова и хвост
   
}