int n;
Console.Write("Введите количество чисел ");
n = Convert.ToInt32(Console.ReadLine());
int cnt = 0;
int[] Array = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    Array[i] = rand.Next(100, 999);
}

Console.Write("[");
for (int i = 0; i < n; i++)
{
    if (Array[i] % 2 == 0)
        cnt = cnt + 1;
    Console.Write(Array[i] + " ");
}
Console.Write("]->");
Console.WriteLine(cnt);
