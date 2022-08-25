
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int [rowCount,columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row,column]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(5,3,0,99);
PrintMatrix(matrix);
