// Подсчитать сумму цифр в числе

Console.Clear();

Console.Write("Введите первый предел рандома: ");
int firstNamber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второй предел рандома: ");
int secondNamber = int.Parse(Console.ReadLine()!);

//  определяем минимальное и максимальное значение рандома
int min;
int max;
if (secondNamber > firstNamber)
{
    min = firstNamber;
    max = secondNamber;
}
else
{
    max = firstNamber;
    min = secondNamber;
}
int number = new Random().Next(min, max);
Console.WriteLine($"считаем сумму цифр в числе: {number}");
//  считаем сумму цифр
int summ = 0;
number = Math.Abs(number);
for (int i = 0; i < number; number /= 10)
{
    summ += number % 10;
}
Console.WriteLine($"сумма цифр в числе равна:{summ}");