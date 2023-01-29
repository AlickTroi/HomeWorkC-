// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("введите цифру от 1 до 7:");
int week = int.Parse(Console.ReadLine()!);

if (week == 1 || week == 2 || week == 3 || week == 4 || week == 5)
{
    Console.WriteLine("Не выходной, идем на работу");
}
else if (week == 6 || week == 7)
{
    Console.WriteLine("Выходной, идем ГУЛЯТЬ :)))))))!!!!");
}
else
{
    Console.WriteLine("Я не помню является ли этот день выходным ,пусть будет Бульельник");
}