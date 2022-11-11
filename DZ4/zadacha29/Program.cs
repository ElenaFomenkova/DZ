int n;
Console.Write("Введите количество чисел ");
n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    Array[i] = rand.Next(-10, 10);
}

for (int i = 0; i < n; i++)
{

    Console.Write(Array[i] + " ");
}