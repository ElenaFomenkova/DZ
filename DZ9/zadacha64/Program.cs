using static System.Console;
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
WriteLine(RecurNumbers(7));