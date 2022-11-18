//Создание двумерного массива.
double[,] createArray(int n, int m)
{
    double[,] array = new double[n, m];
    return array;
}

//Заполнение массива.
double[,] fillArray(double[,] array, double min, double max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() * (max - min) + min;
        };
    };
    return array;
}
Console.Write("Введите количество строк массива");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());
double[,] Array = createArray(n, m);
Array = fillArray(Array, -10, 10);
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Console.Write("{0,6:F2}", Array[i, j]);
        Console.Write(" ");
    };
    Console.WriteLine();
};