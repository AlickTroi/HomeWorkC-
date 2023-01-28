// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.WriteLine("введите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите второе число");
int num3 = int.Parse(Console.ReadLine()!);
 int max = num1;
 if (num1 < num2)
 {
    max = num2;
 }
 else
 {

 }
 if (max < num3)
 {
    max = num3;
 }
else
{

}
 Console.WriteLine($"самое большое число {max}");