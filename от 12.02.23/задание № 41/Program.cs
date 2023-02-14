// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число:");
        result[i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

int MoreThanZero(int[] array)
{
    int moreZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            moreZero++;
        }
    }
    return moreZero;
}

Console.Clear();

Console.Write("Введите длину массива:");
int m = int.Parse(Console.ReadLine()!);
int[] array = GetArray(m);
Console.WriteLine(string.Join(", ", array));

int moreThanZero = MoreThanZero(array);
Console.WriteLine($"чисел больше 0 = {moreThanZero}");
