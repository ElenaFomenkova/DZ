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

int FindMinSumInRows(int[,] array)
{
    int index = 1;
    int min = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min = min + array[0, j];
    }
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }

        if (sum < min)
        {
            min = sum;
            index = i + 1;
        }
        sum = 0;
    }
    return index;
}

int[,] array = createArray(3, 5);
array = fillArray(array, 0, 20);
printArray(array);
Console.WriteLine("");
Console.WriteLine(FindMinSumInRows(array));