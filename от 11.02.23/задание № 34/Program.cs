// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int CountEvenNumber(int[] array)
{
    int evenCount = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
}
Console.Clear();

Console.Write("введите размер масива:");
int sizeMassif = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[] massif = GetArray(sizeMassif, 100, 999);
Console.WriteLine(String.Join(", ", massif));
Console.WriteLine();

int evenNumbered = CountEvenNumber(massif);
Console.WriteLine($"в массиве количество четных чисел = {evenNumbered}");