// 

int[,] GetTable(int sizeRows, int sizeColomns, int minValue, int maxValue)
{
    int[,] result = new int[sizeRows, sizeColomns];

    for (int rows = 0; rows < sizeRows; rows++)
    {
        for (int colomn = 0; colomn < sizeColomns; colomn++)
        {
            result[rows, colomn] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[] AnticlockwiseWithdrawal(int[,] array)
{
    int maximuFaceSize;
    int rowsSize = array.GetLength(0);
    int colomnsSize = array.GetLength(1);
    int size = rowsSize * colomnsSize;
    int[] result = new int[size];
    int rows = 0;
    int colomns = colomnsSize;
    int count = 0; //
    if (rowsSize <= colomnsSize)
    {
        if (rowsSize % 2 == 0)
        {
            maximuFaceSize = rowsSize / 2;
        }
        else
        {
            maximuFaceSize = (rowsSize / 2) + 1;
        }
    }
    else
    {
        if (colomnsSize % 2 == 0)
        {
            maximuFaceSize = colomnsSize / 2;
        }
        else
        {
            maximuFaceSize = (colomnsSize / 2) + 1;
        }
        
    }

for (int i = 0; i < maximuFaceSize; i++)
{
    int countRight = 0;
    int countUp = 0;
    int countLeft = 0;
    int countDown = 0;
    while (countRight < rowsSize - i)
    {
        result[count] = array[rows + countRight , colomns];
        countRight++;
        count++;
    }
    if (count + 1 == size)
    {
        return result;
    }
    while (countUp < rowsSize - i)
    {
        result[count] = array[rows , colomns - countUp];
        countUp++;
        count++;
    }
    while (countLeft < rowsSize - i)
    {
        result[count] = array[rows - countLeft , colomns];
        countLeft++;
        count++;
    }
    while (countDown < rowsSize - i - 1)
    {
        result[count] = array[rows , colomns + countDown];
        countDown++;
        count++;
    }
}
return result;
}

void GiveTable(int[,] chart)
{
    for (int rows = 0; rows < chart.GetLength(0); rows++)
    {
        for (int colomn = 0; colomn < chart.GetLength(1); colomn++)
        {
            Console.Write($"-{chart[rows, colomn]}-");
        }
        Console.WriteLine();
    }
}


int[,] ar = GetTable(3, 3, 0, 10);
GiveTable(ar);

int[] y = AnticlockwiseWithdrawal(ar);
Console.WriteLine(string.Join(", ", y));