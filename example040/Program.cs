//Задача 40: Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();

int numberOne = GetNumberFromUser("Введите размер первой стороны треугольника", "Ошибка ввода");
int numberTwo = GetNumberFromUser("Введите размер второй стороны треугольника", "Ошибка ввода");
int numberTree = GetNumberFromUser("Введите размер третьей стороны треугольника", "Ошибка ввода");
Console.WriteLine(String.Join(" ", numberOne, numberTwo, numberTree));
GetAnswer( numberOne, numberTwo, numberTree); 

void  GetAnswer(int One, int Two, int Tree)
{
if(One > Two + Tree || Two > One + Tree || Tree > One + Two)
{
    Console.WriteLine($"Треугольник со сторонами {One}, {Two}, {Tree} существовать не может ");
}
else
{
    Console.WriteLine($"Треугольник со сторонами {One}, {Two}, {Tree} существовать  может ");
} 
}


int GetNumberFromUser(string Message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int SizeFromUser);
        if (isCorrect)
        {
            return SizeFromUser;
        }
        Console.WriteLine(errorMessage);
    }
}