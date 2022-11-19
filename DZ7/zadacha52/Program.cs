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
// Подсчет среднего арифметического
void GetAwerageArray(int[,] inputArray)
{

    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        float sum = 0;
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            sum = sum + inputArray[j, i];
        }
        Console.WriteLine(sum/inputArray.GetLength(0));
    }
}

Console.Write("Введите количество строк массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());

int[,] Array = createArray(n, m);
Array = fillArray(Array, -10, 10);
printArray(Array);

GetAwerageArray(Array);