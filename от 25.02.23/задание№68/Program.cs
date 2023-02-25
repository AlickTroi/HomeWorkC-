// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n. 

int FunctionAccermana(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAccermana(m - 1, 1);
    else return FunctionAccermana(m - 1, FunctionAccermana(m, n - 1));
}

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(FunctionAccermana(n, m));