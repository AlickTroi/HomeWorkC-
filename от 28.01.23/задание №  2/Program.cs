// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("введите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
int max, min;
if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}

Console.WriteLine($"max = {max} > min = {min}");