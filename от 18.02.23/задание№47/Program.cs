// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами
Console.Clear();

float[,] GetTable(int sizeRows, int sizeColomns)
{
    float[,] result = new float[sizeRows, sizeColomns];

    for (int rows = 0; rows < sizeRows; rows++)
    {
        for (int colomn = 0; colomn < sizeColomns; colomn++)
        {
            float i = new Random().Next(-999999, 1000000);
            result[rows, colomn] = i / 100;
        }
    }
    return result;
}

void PrintTable(float[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

float[,] array = GetTable(m, n);
PrintTable(array);