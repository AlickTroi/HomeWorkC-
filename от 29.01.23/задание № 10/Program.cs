// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает
// вторую цифру этого числа.

Console.Clear();

Console.WriteLine("введите любое число больше 100:");
int tree = int.Parse(Console.ReadLine()!);

int decision = (tree / 10) % 10;
if (tree < 100)
{
    Console.WriteLine("вы ввели число меньше 100");
}
else
{
    Console.WriteLine($"в разряде десятков находится число {decision}");
}