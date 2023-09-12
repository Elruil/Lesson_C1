//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


Console.Clear();
Console.WriteLine("Введите знаения числа ");
int Num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите знаения числа ");
int St = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{Num} в {St}");
int result = GetSqr(Num, St);

int GetSqr(int Num, int St)
{
    if(St == 0) return 1;
    else if (St%2 == 0) return GetSqr(Num * Num, St/2);
    else return GetSqr(Num, St - 1) * Num;
}
Console.WriteLine($"{result}");