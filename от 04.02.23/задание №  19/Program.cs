//  Напишите программу, которая принимает
//  на вход пятизначное число и проверяет, является ли
//  оно палиндромом.

Console.Clear();

Console.WriteLine("введите пятизначное число");
int fiveDigitNumber = int.Parse(Console.ReadLine()!);

if (fiveDigitNumber >= 10000 && fiveDigitNumber < 100000)
{
    int fiveDigitNumber1 = (fiveDigitNumber / 10000) % 10;
    int fiveDigitNumber2 = (fiveDigitNumber / 1000) % 10;
    int fiveDigitNumber4 = (fiveDigitNumber / 10) % 10;
    int fiveDigitNumber5 = fiveDigitNumber % 10;
    if (fiveDigitNumber1 == fiveDigitNumber5 && fiveDigitNumber2 == fiveDigitNumber4)
    {
        Console.WriteLine("да, ваше число является палиндромом!!!");
    }
    else
    {
        Console.WriteLine("нет, ваше число не является палиндромом(((");
    }
}
else
{
    Console.WriteLine("у вас не пятизначное число");
}