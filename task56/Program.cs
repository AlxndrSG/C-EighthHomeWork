// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] array = new[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}
};

PrintArray(array);

int lineSumNumbers = FindLineMinSumNumbers(array);
Console.WriteLine($"\n{lineSumNumbers + 1} - строка с наименьшей суммой элементов");

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
}

int SumLineNumbers(int[,] arr, int i)
{
    int sumLine = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sumLine += arr[i, j];
    }
    return sumLine;
}

int FindLineMinSumNumbers(int[,] arr)
{
    int minSumLine = 0;
    int sumLine = SumLineNumbers(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tempSumLine = SumLineNumbers(arr, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    return minSumLine;
}

