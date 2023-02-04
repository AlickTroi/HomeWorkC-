// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int count = 1;
Console.Write("введте число: ");
int lastNumber = int.Parse(Console.ReadLine());

while (count <= lastNumber)
{
    Console.Write(count * count * count);
    if (count != lastNumber)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
    count++;
}