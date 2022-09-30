

int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[4, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(01, 99);
        }
    }
    return array;
}

int[,] SpiralArray(int[,] array)
{
    int count = 1;
    int startRow = 0;
    int endRow = array.GetLength(0) - 1;
    int startCol = 0;
    int endCol = array.GetLength(1) - 1;

    while (startRow <= endRow && startCol <= endCol)
    {
        for (int j = startCol; j <= endCol; j++)
        {
            array[startRow, j] = count;
            count++;
        }
        startRow++;
        for (int i = startRow; i <= endRow; i++)
        {
            array[i, endCol] = count;
            count++;
        }
        endCol--;
        for (int j = endCol; j >= startCol; j--)
        {
            array[endRow, j] = count;
            count++;
        }
        endRow--;
        for (int i = endRow; i >= startRow; i--)
        {
            array[i, startCol] = count;
            count++;
        }
        startCol++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

int[,] arr = GenerateArray(4, 4);
SpiralArray(arr);
PrintArray(SpiralArray(arr));
