int[,] GenerateArray(int GetLength1, int GetLength2)
 {
    int[,] array = new int[3, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 99);
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


int[,] DecreasingElementRowsArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int l = j + 1; l < array.GetLength(1); l++)
                if (array[i, j] < array[i, l])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, l];
                    array[i, l] = temp;
                }
        }
    }
    return array;

}
int[,] arr = GenerateArray(3, 4);
PrintArray(arr);
Console.WriteLine();
int[,] arr1 = DecreasingElementRowsArray(arr);
PrintArray(arr1);
