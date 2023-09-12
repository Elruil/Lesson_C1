//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30


Console.Clear();
Console.WriteLine("Введите знаения числа M ");
int NumOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите знаения числа N");
int NumTwo = int.Parse(Console.ReadLine() ?? "");
Console.Write($"M - {NumOne} ;  N - {NumTwo}");
if (NumOne > NumTwo)
{
    int temp = 0;
    temp = NumOne;
    NumOne = NumTwo;
    NumTwo = temp;
}
int Sum = GetSum(NumOne, NumTwo);
int GetSum(int NumOne, int NumTwo)
{

 if (NumTwo < NumOne) return 0;

    else return NumOne + GetSum(NumOne +1, NumTwo);

}
Console.Write($"  => {Sum}");
