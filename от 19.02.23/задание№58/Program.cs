// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int value = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                value += firstMatrix[i, k] * secondMatrix[k, j];
            }
            result[i, j] = value;
        }
    }
    return result;
}









Console.Write("1 матрица: Введите чиcло строк: ");
int rowsOne = int.Parse(Console.ReadLine()!);
Console.Write("1 матрица: Введите чиcло колон: ");
int colomnsOne = int.Parse(Console.ReadLine()!);

Console.Write("2 матрица: Введите чиcло строк: ");
int rowsTwo = int.Parse(Console.ReadLine()!);
Console.Write("2 матрица: Введите чиcло колон: ");
int colomnsTwo = int.Parse(Console.ReadLine()!);

Console.WriteLine("-----------");
int[,] samplerOne = GetArray(rowsOne, colomnsOne, 0, 10);
PrintArray(samplerOne);
Console.WriteLine("-----------");
int[,] samplerTwo = GetArray(rowsTwo, colomnsTwo, 0, 10);
PrintArray(samplerTwo);


Console.WriteLine("-----------");

if (samplerOne.GetLength(1) == samplerTwo.GetLength(0))
{
    int[,] sum = MatrixMultiplication(samplerOne, samplerTwo);
    PrintArray(sum);
}
else
{
    Console.WriteLine("ваши матрицы не получается перемножить");
}
