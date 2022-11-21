int RecurSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + RecurSum(m, n - 1);
    }
}
System.Console.WriteLine(RecurSum(1, 15));