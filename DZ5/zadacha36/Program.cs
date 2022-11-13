int n;
Console.Write("Введите количество чисел ");
n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    Array[i] = rand.Next(-10, 10);
}
Console.Write("[");
int Sum = 0;
for (int i = 0; i < n; i++)
{
    if ((i + 1) % 2 != 0) //позиция не равна индексу
    {
        Sum = Sum + Array[i];
    }
    Console.Write(Array[i] + " ");
}
Console.Write("] ->");
Console.Write(Sum);
