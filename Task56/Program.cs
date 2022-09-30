int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[5, 7];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumElementsRows(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum1 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum1 = array[i, j] + sum1;
        }
        sum = sum1;
        Console.Write($"{sum} ");
    }
    return sum;
}

int[] SumElementsRowsArray(int[,] array, int length)
{
    int[] NewArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        NewArray[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            NewArray[i] = array[i, j] + NewArray[i];
        }
    }
    return NewArray;
}

int MinSumElementsRows(int[] NewArray)
{
    int min = NewArray[0];
    int i = 0;
    while (i < NewArray.Length)
    {
        if (NewArray[i] < min)
            min = NewArray[i];
        i++;
    }
    int find = min;
    int row = 0;
    for (i = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i] == find)
            row = i + 1;
    }
    Console.Write($"Номер строки  с наименьшей суммой элементов -> {row}");
    return row;
}

int[,] arr = GenerateArray(5, 7);
PrintArray(arr);
Console.Write($"Сумма элементов каждой строки -> ");
SumElementsRows(arr);
Console.WriteLine();
int[] arr1 = SumElementsRowsArray(arr, 5);
MinSumElementsRows(arr1);
