// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int NotEvenAmount(int[] array)
{
    int ontEvenAmount = 0;
    foreach (int element in array)
    {
        if (element % 2 == 1)
        {
            ontEvenAmount += element;
        }
    }
    return ontEvenAmount;
}

Console.Clear();

int[] massif = GetArray(100, 0, 100);
Console.WriteLine(String.Join(", ", massif));
Console.WriteLine();

int nutEven = NotEvenAmount(massif);
Console.WriteLine($"в массиве сумма нечетных чисел = {nutEven}");