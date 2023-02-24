//  Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] GetArray(int rows, int colomns, int height)
{

    int[,,] result = new int[rows, colomns, height];
    int count = 10;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            for (int k = 0; k < height; k++)
            {
                result[i, j, k] = count++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                Console.Write($" {massiv[i, j, k]} ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Console.Write("Введите чиcло строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите чиcло колон: ");
int colomns = int.Parse(Console.ReadLine()!);
Console.Write("Введите высоту: ");
int height = int.Parse(Console.ReadLine()!);

Console.WriteLine("-----------");
if (rows * colomns * height <= 89)
{
int[,,] sampler = GetArray(rows, colomns, height);
PrintArray(sampler);
}
else 
{
    Console.WriteLine("условие: целых неповторяющихся двух значных чисел не возможно");
}