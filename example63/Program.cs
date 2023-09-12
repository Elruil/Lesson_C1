//Задача 63: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Введите знаения числа ");
int NumOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите знаения числа ");
int NumTwo = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"{NumOne}, {NumTwo}.");

string GetNat(int NumOne, int NumTwo)
{

    if (NumTwo + 1 > NumOne) return $"{NumOne} " + GetNat(NumOne + 1, NumTwo);

    else return String.Empty;




}
Console.WriteLine(GetNat(NumOne, NumTwo));