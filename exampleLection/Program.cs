﻿/*string[,] table = new string[2, 5];
table [1,2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine ($"-{table[rows, columns]}-");
    }
}*/
/*
int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);    
void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matr.GetLength(1);columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();  
    } 
    
}
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

*/
/*
double Factorial (int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/
// f(1) = 1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2);
int Fibbonacci(int n)
{
    if( n == 1 || n == 2 ) return 1;
    else return Fibbonacci(n -1) +Fibbonacci(n -2);
}
for( int i = 1; i<40;i++ )
{
    Console.WriteLine($"{i} = {Fibbonacci(i)}");
}