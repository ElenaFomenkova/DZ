string RecurNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return n + ", " + RecurNumbers (n - 1);
    }
}
System.Console.WriteLine(RecurNumbers(7));