int n;
Console.Write("Введите количество чисел ");
n = Convert.ToInt32(Console.ReadLine());
double[] Array = new double[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    Array[i] = rand.NextDouble();
}
Console.Write("[");
double max = Array[0];
double min = Array[0];

for (int i = 0; i < n; i++)
{
    if (Array[i] > max)
    {
        max = Array[i];
    }
    if (Array[i] < min)
    {
        min = Array [i];
    }
    Console.Write("{0,6:F2}", Array[i]);
    Console.Write(", ");
}
Console.Write("] -> ");
Console.Write("{0,6:F2}", max-min);