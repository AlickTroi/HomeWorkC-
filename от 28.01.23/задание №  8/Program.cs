// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число");
int allNumb = int.Parse(Console.ReadLine()!);
int count = 2;
while (count <= allNumb)
{
    Console.Write($"{count} ");
    count += 2 ;
}
