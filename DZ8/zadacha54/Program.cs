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
static int[,] BubbleSort(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = j + 1; a < array.GetLength(1); a++)
            {
                if (array[i, j] < array[i, a])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, a];
                    array[i, a] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = createArray(n, m);
array = fillArray(array, 0, 50);
printArray(array);
array = BubbleSort(array);
Console.WriteLine("Готовый массив");
printArray(array);