//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до M.
//M = 1; N = 5. -> “5, 4, 3, 2, 1"
//M = 4; N = 8. -> “8, 7, 6, 5, 4"

Console.Clear();
Console.WriteLine("Введите знаения числа M ");
int NumOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите знаения числа N");
int NumTwo = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"M - {NumOne}, N - {NumTwo}.");
if (NumOne > NumTwo)
{
    int temp = 0;
    temp = NumOne;
    NumOne = NumTwo;
    NumTwo = temp;
}
Console.WriteLine(GetNat(NumOne, NumTwo));
string GetNat(int NumOne, int NumTwo)
{

    if (NumTwo + 1 > NumOne) return $"{NumTwo} " + GetNat(NumOne, NumTwo - 1);

    else return String.Empty;

}
