// Напишите программу, которая заполнит спирально массив 4 на 4.


Console.Clear();

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

int[,] ArrayFiledSpirally(int rows, int colomns)
{
    int[,] result = new int[rows, colomns];
    int round;
    if (rows > colomns)
    {
        round = rows / 2;
    }
    else
    {
        round = colomns / 2;
    }

    int count = 0;
    for (int i = 0; i < round; i++)
    {
        for (int j = 0 + i; j < colomns - i; j++)
        {
            result[i, j] = count++;
        }
        if (count >= colomns * rows)
        {
            break;
        }
        for (int k = 1 + i; k < rows - i; k++)
        {
            result[k, colomns - 1 - i] = count++;
        }
        if (count >= colomns * rows)
        {
            break;
        }
        for (int l = colomns - 2 - i; l >= 0 + i; l--)
        {
            result[rows - 1 - i, l] = count++;
        }
        if (count >= colomns * rows)
        {
            break;
        }
        for (int m = rows - 2 - i; m > 0 + i; m--)
        {
            result[m, i] = count++;
        }
    }

    if (rows == colomns && rows % 2 == 1)
    {
        result[rows / 2, colomns / 2] = count++;
    }


    return result;
}

Console.Write("Введите чиcло строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите чиcло колон: ");
int colomns = int.Parse(Console.ReadLine()!);

Console.WriteLine("-----------");
int[,] sampler = ArrayFiledSpirally(rows, colomns);
PrintArray(sampler);