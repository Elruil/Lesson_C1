//напишите програму, которая принимает на вход координаты точки X и Y 
// причем x!=0 и y!=0 и выдает номер четверти плоскости в которой находится точка.
#region --- 00. Configuration ---

Console.Clear();
Console.Title = "Задача 17. Определение номера четверти по заданным координатам";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************
Напишите программу, которая принимает на вход координаты точки (X и Y),
        причем X != 0 и Y != 0 и выдает номер четверти плоскости,
                в котрой находится эта точка.
***********************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion
#region --- 01. Input operations ---
//Вызоы метода, запрашивающего у пользователя целое число. Введенное число присваивается переменной Х
int x = GetNumberFromUser("Введите координату х: ", "Ошибка ввода данных!");
////Вызоы метода, запрашивающего у пользователя целое число. Введенное число присваивается переменной y
int y = GetNumberFromUser("Введите координату у: ", "Ошибка ввода данных!");
#endregion
#region --- 02. Buisness Logic ---
int quarter;
try
{
    //Вызов метода, возвращающего номер четверти по переданным координатам x и y.
    //Результат вызова присваивается переменной quarter
    quarter = GetQuarterByCoords(x, y);
}
catch (Exception exc)
{
    Console.WriteLine($"Ощибка ! {exc.Message}");
    return;// Завершение программы в случае ошибки
}


#endregion
#region --- 03. Output operations ---
Console.WriteLine($"Номер четверти: {quarter}");
static int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        try{
            Console.WriteLine("Введите целое число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch(Exception exc)
        {
            Console.WriteLine($"Ошибка ыыода данных! {exc.Message}");
        }
    }
}
static int GetQuarterByCoords(int x, int y)
{
    if(x>0 && y>0)
    return 1;
    else if(x<0 && y>0)
    return 2;
    else if(x<0 && y<0)
    return 3;
    else if(x>0 && y<0)
    return 4;
    else
        throw new Exception("Точка попадает на оси координат");   
}
#endregion
//                             конец программы

/*
int X = 0;
int Y = 0;
InitCoordinate(ref X, ref Y);
PrintQuarterByCoords(X, Y);

static void InitCoordinate(ref int x, ref int y)
{
    try
    {
        Console.WriteLine("Введите X: ");
        x = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void PrintQuarterByCoords(int X, int Y)
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("1 четверть");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("3 четверть");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("4 четверть");
    }
    else
    {
        Console.WriteLine("Ошибка. Точка попадает на оси координат");
    }
}
*/
