//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя 
//индексы каждого элемента.
//Массив размером 2 x 2 x 2

Console.Clear();

int[,,] array = GetArray(2, 2, 2);

PrintArray(array);

int[,,] GetArray(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            for (int k = 0; k < arr.GetLength(2); k++)
            {

                Console.Write($"{arr[i, j, k]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}