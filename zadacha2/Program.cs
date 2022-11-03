int a = -9;
int b = -3;

int max = a;
int min = b;

if (b > a)
{
    min = a;
    max = b;
}

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);

