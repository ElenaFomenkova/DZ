Console.Write("Введите элементы через пробел");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int cnt = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        cnt = cnt + 1;
    }
}

Console.WriteLine($"Количество элементов > 0: {cnt}");
