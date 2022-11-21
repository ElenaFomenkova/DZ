int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
      if ((n == 0) & (m > 0))
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return Akk(m - 1, Akk(m, n - 1));
    }
}

System.Console.WriteLine(Akk(3, 2));
