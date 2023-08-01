//ВИДЫ МЕТОДОВ
// 1 вид
//void Method1()
//{
//    Console.WriteLine("Автор ...");
//}
//Method1();
// 2 вид
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    { 
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
Console.WriteLine(" ");
Method21(count : 4, msg : "Текст");*/
// 3 вид
/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */
// 4 вид
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4( c:" Новый текст", count : 4);
Console.WriteLine(res);