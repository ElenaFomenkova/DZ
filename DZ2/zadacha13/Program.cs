int a = 32679;
if (a >= 100)
{
    while (a > 999)
    {
        a = a / 10;
    }
    a = a % 10;
    Console.WriteLine(a);
}
else
    Console.WriteLine("Третьей цифры нет");
