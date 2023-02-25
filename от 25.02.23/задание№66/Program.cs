// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

Console.Clear();

int SumOfNaturalNumbers(int n, int m)
{
    if (n == m) return n;
    else return n + SumOfNaturalNumbers(n - 1, m);
}

Console.Write("Введите число c которого будем идти: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число до которого будем идти: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumOfNaturalNumbers(n, m));