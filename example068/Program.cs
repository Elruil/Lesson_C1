//Задача 68: Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("Введите знаения числа M ");
int NumOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите знаения числа N");
int NumTwo = int.Parse(Console.ReadLine() ?? "");
Console.Write($"M - {NumOne} ;  N - {NumTwo}");

int Result = GetResult(NumOne, NumTwo);
int GetResult(int NumOne, int NumTwo)
{
    if(NumOne == 0) return NumTwo + 1;
    else if ((NumOne != 0) && (NumTwo == 0)) return GetResult(NumOne - 1, 1);
    else  return GetResult(NumOne - 1, GetResult(NumOne, NumTwo - 1));

}


Console.Write($"  => {Result}");
