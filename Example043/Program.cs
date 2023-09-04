//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 Console.Clear();

 double b1 = GetNumberFromUser("Введите целое число для определения значения b1", "Ошибка ввода");
 double k1 = GetNumberFromUser("Введите целое число для определения значения k1", "Ошибка ввода");
 double b2 = GetNumberFromUser("Введите целое число для определения значения b2", "Ошибка ввода");
 double k2 = GetNumberFromUser("Введите целое число для определения значения k2", "Ошибка ввода");

if (b1 == k1)
{
    Console.WriteLine("Прямые паралельны");
}
else
{
double x = (b2 - b1)/(k1 - k2);
double y = (k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"Введенные значения b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}. Точка пересечения ({x};{y}) ");
}

 double GetNumberFromUser(string Message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(Message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double SizeFromUser);
        if (isCorrect)
        {
            return SizeFromUser;
        }
        Console.WriteLine(errorMessage);
    }
}
