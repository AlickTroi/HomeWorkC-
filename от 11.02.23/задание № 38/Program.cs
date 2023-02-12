// Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        int random = new Random().Next(minValue, maxValue + 1);
        double randomDouble = new Random().NextDouble();
        result[i] = Math.Round(random + randomDouble, 3);
    }
    return result;
}

double BigToSmallDifference(double[] array)
{
    double min = array[0];
    double max = array[0];

    foreach (double element in array)
    {
        if (element > max)
        {
            max = element;
        }
        else if (element < min)
        {
            min = element;
        }
    }
    double distinction = max - min;
    return distinction;
}

Console.Clear();

double[] array = GetArray(20, -100, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();

double sum = BigToSmallDifference(array);
Console.WriteLine($"разница между макимальным и минимальным = {sum}");

