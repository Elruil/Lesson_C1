Console.Clear();
int Quarter = GetNumQuarter("Введите номер четверти", "Ошибка ыыода данных!");
GetDiapason(Quarter);

static int GetNumQuarter(string Message, string errorMessage)
{
    while (true)
    {
        try
        {
            Console.WriteLine(Message);
            int numQuarter = int.Parse(Console.ReadLine() ?? "");
            return numQuarter;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");
        }
    }
}

static void GetDiapason(int num)
{
    if (num == 1)
        Console.WriteLine("Возможные координаты по X и Y от 1 до бесонечности  ");
    else if (num == 2)
        Console.WriteLine("Возможные координаты по X  от -1 до минус бесконечности по Y от 1 до бесконечности");
    else if (num == 3)
        Console.WriteLine("Возможные координаты по X  от -1 до минус бесконечности по Y от -1 до -бесконечности");
    else if (num == 4)
        Console.WriteLine("Возможные координаты по X  от 1 до + бесконечности по Y от -1 до -бесконечности");
    else
        Console.WriteLine("Неправильный номер четверти");
}