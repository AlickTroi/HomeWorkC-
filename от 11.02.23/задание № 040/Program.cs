// Разобраться с алгоритмом сортировки методом пузырька.
// Реализовать невозрастающую сторировку.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] BubbleSort(int[] array)
{
    int size = array.Length;
    foreach (int el in array)
    {
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
    return array;
}

int[] massif = GetArray(100, -100, 100);
Console.WriteLine(String.Join(", ", massif));
Console.WriteLine();

int[] mas = BubbleSort(massif);
Console.WriteLine(String.Join(", ", mas));
Console.WriteLine();

