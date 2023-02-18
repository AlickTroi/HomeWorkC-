//  Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.Clear();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-10, 10);
        }
    }
    return result;
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

void IndexCheck(int[,] array, int rows, int colomns)
{
    int i = rows;
    int j = colomns;
    if (rows > array.GetLength(0) || colomns > array.GetLength(1))
    {
        Console.WriteLine($"{i},{j} -> такого числа в массиве нет");
    }
    else 
    {
        Console.WriteLine($"{i},{j} -> {array[rows-1, colomns-1]}");
    }
}

Console.Write("введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("введите количество столбцов: ");
int colomn = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, colomn);
PrintArray(array);

Console.Write("введите строку для поиска: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("введите столбец для поиска: ");
int n = int.Parse(Console.ReadLine()!);


IndexCheck(array, m, n);
