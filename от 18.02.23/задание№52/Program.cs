// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void AverageColomns(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(1); i++)
    {
        float result = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            result += arr[j, i];
        }
    Console.Write($"{result / arr.GetLength(0)}\t");
    }  
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}




Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);

PrintArray(array2D);
Console.WriteLine();
AverageColomns(array2D);