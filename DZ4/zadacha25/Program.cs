double Pow(int a, int b)
{
    if (a == 0 && b == 0) return double.NaN;
    bool flag;
    flag = b > 0;
    if (b < 0) b = -b;
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res = res * a;
    }
    if (flag) return res;
    else return 1.0 / res;
}

System.Console.WriteLine(Pow(2, 4));
  