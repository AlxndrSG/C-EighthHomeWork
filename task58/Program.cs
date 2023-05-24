// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

Console.Clear();
int[,] array1 = new[,]
{
    {2,4},
    {3,2}
};
Console.WriteLine($"Первая матрица: ");
PrintArray(array1);

int[,] array2 = new[,]
{
    {3,4},
    {3,3}
};
Console.WriteLine($"Вторая матрица: ");
PrintArray(array2);

int[,] result = new int[2, 2];
ResultArray(array1, array2, result);

Console.WriteLine($"Произведение матриц: ");
PrintArray(result);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ResultArray(int[,] arr1, int[,] arr, int[,] result)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * array2[k, j];
            }
            result[i, j] = sum;
        }
    }
}

