int[] OneArray(int length)
{
    Random rnd = new Random();
    int[] Array = new int[10];
    Array[0] = rnd.Next(10, 99);
    for (int i = 1; i < Array.Length;)
    {
        int num = rnd.Next(10, 99); 
        int j;
        
        for (j = 0; j < i; j++)
        {
            if (num == Array[j])
                break; 
        }
        if (j == i)
        { 
            Array[i] = num; 
            i++; 
        }
    }
    return Array;
}

int[,,] NumberArray(int[] Array)
{
    int[,,] ThirdArray = new int[2, 2, 2];
    int index = 0;
    for (int i = 0; i < ThirdArray.GetLength(0); i++)
    {
        for (int j = 0; j < ThirdArray.GetLength(1); j++)
        {
            for (int k = 0; k < ThirdArray.GetLength(2); k++)
            {
                ThirdArray[i, j, k] = Array[index];
                index++;
            }

        }
    }
    return ThirdArray;
}

void PrintArray(int[,,] ThirdArray)
{
    for (int i = 0; i < ThirdArray.GetLength(0); i++)
    {
        Console.WriteLine($"Page №  {i + 1}");

        for (int j = 0; j < ThirdArray.GetLength(1); j++)
        {
            for (int k = 0; k < ThirdArray.GetLength(2); k++)
            {
                Console.Write($"{ThirdArray[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] arr = NumberArray(OneArray(10));
PrintArray(arr);
