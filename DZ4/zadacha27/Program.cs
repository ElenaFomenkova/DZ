int n = 9012;
int res = 0;
while (n > 0)
{
    res = res + n % 10;
    n = n / 10;
}
Console.WriteLine(res);
