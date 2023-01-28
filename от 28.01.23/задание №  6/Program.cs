// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine("Введите число");
int even = int.Parse(Console.ReadLine()!);

even = even % 2;
if (even == 1)
{
    Console.WriteLine("данное число не четное");
}
else
{
    Console.WriteLine("данное число четное");
}