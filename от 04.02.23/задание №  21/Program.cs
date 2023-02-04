//  Напишите программу, которая принимает
//  на вход координаты двух точек и находит расстояние
//  между ними в 3D пространстве.

Console.Clear();

Console.Write("введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double matchX = Math.Pow(x1 - x2, 2);
double matchY = Math.Pow(y1 - y2, 2);
double matchZ = Math.Pow(z1 - z2, 2);

double match = Math.Sqrt(matchX + matchY + matchZ);
Console.WriteLine($"{match:f2}");