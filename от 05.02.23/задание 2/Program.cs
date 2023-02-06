// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();

Console.WriteLine("вычисления произведения чисел от 1 до N");
Console.Write("введите конечное число: ");
int lastNumber = int.Parse(Console.ReadLine()!);
if (lastNumber > 0)
{
    int worksOfNumbers = 1;
    for (int i = 1; i <= lastNumber; i++)
    {
        worksOfNumbers *= i;
    }
    if (worksOfNumbers != 0)
        Console.Write(worksOfNumbers);
    else
        Console.WriteLine("ваше число больше того что модет вместить тип данных int");
}
else
    Console.Write("вы ввели число меньше 1");