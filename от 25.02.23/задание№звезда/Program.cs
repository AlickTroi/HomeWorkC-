// Пользователь вводит скобочные последовательности. В
// последовательности могут встретиться скобки вида: {}, (), []
Console.Clear();

bool BraceTest(string line)
{
    int count = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i] == '(') count++;
        else count--;
        if (count < 0) return false;
    }
    return count == 0;
}

