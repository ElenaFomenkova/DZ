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
    Console.WriteLine();
}
int[,] productMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    int newElement;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            newElement = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                newElement = newElement + array1[i, k] * array2[k, j];
            }
            array3[i, j] = newElement;
        }
    }
    return array3;
}
int n1 = 3;
int m1 = 2;
int n2 = m1;
int m2 = 3;
int[,] array1 = createArray(n1, m1);
int[,] array2 = createArray(n2, m2);
array1 = fillArray(array1, -10, 10);
array2 = fillArray(array2, 0, 5);
printArray(array1);
printArray(array2);
printArray(productMatrix(array1,array2));