// квадратного корня, которая принимает на
// вход целочисленное значение x и возвращает целую часть квадратного
// корня от введенного числа.


int SquareRoot(int total)
{
    int factor = total / 2;
    while (factor * factor > total)
    {
        factor /= 2;
    }
    while (factor * factor < total)
    {
        factor += 1;
    }
    
    int residue = total % factor;
    Console.WriteLine(factor);
    return residue;
}


Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(SquareRoot(num));