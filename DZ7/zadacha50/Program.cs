//Создание двумерного массива.
int[,] createArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

//Заполнение массива.
int[,] fillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        };
    };
    return array;
}
// Печать массива
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Проверка попадания запрошенной координаты в размерность массива
bool IsCoordinatesExist(int n, int m, int x, int y)
{
    if (x <= 0 || x > n)
    {
        return false;
    }
    if (y <= 0 || y > m)
    {
        return false;
    }
    return true;
}

Console.Write("Введите количество строк массива");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());

int[,] Array = createArray(n, m);
Array = fillArray(Array, -10, 10);
printArray(Array);

Console.Write("Введите позицию строки");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию столбца");
int y = Convert.ToInt32(Console.ReadLine());

if (IsCoordinatesExist(n, m, x, y))
{
    Console.WriteLine(Array[x - 1, y - 1]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}