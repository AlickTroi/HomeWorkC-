// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

string GoToLive(int n)
{
    if (n == 1) return 1.ToString();
    else return n.ToString() + ", " + GoToLive(n - 1);
}


Console.Write("Введите число до которого будет идти: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GoToLive(n));