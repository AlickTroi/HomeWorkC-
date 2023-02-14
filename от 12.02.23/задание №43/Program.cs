//  Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

int[] MeetStraightLineX(int k1, int b1, int k2, int b2)
{
    int[] result = new int[2];
int x = b2 - b1/(k1 - k2);
result[0] = x;
int y = k1 * x + b1;
result[1] = y;
return result;
}

Console.Clear();

Console.Write("Введите k1:");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b1:");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k2:");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2:");
int b2 = int.Parse(Console.ReadLine()!);



if (k1 == k2 && b1 == b2)
{
    Console.Write("2 линии находятся друг на друге");
}
else if (k1 == k2)
{
    Console.Write("ваши линии идут паралельно пересечений нет");
}
else
{
    int[] calculated = MeetStraightLineX(k1, b1, k2, b2);
Console.Write("пересечения двух прямых происзодит в точке(");
Console.Write(String.Join(" ,", calculated));
Console.Write(")");
}