// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

Console.Write("введите конечное число: ");
int max = int.Parse(Console.ReadLine()!);
int print;

for (int i = 0; i <= max; i += 2)
{
    print = i * i * i;
    Console.WriteLine($"куб числа {i} = {print}");
}