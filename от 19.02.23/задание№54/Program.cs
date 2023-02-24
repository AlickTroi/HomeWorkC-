// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] GetArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] result = new int[rows, colomns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($" {massiv[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void OrderToRows(int[,] massiv)
{
    int temp;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 1; k < massiv.GetLength(1); k++)
            {
                if (massiv[i, k] > massiv[i, k - 1])
                {
                    temp = massiv[i, k - 1];
                    massiv[i, k - 1] = massiv[i, k];
                    massiv[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Введите чиcло строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите чиcло колон: ");
int colomns = int.Parse(Console.ReadLine()!);

Console.WriteLine("-----------");
int[,] sampler = GetArray(rows, colomns, 0, 100);
PrintArray(sampler);
Console.WriteLine("-----------");
OrderToRows(sampler);
PrintArray(sampler);
Console.WriteLine("-----------");