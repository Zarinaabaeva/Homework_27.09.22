int[,] Matrix1(int rows, int columns)
{
    int[,] MatrixArray1 = new int[2, 2];

    for (int i = 0; i < MatrixArray1.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray1.GetLength(1); j++)
        {
            MatrixArray1[i, j] = new Random().Next(1, 10);
        }
    }
    return MatrixArray1;
}

int[,] Matrix2(int rows, int columns)
{
    int[,] MatrixArray2 = new int[2, 2];

    for (int i = 0; i <  MatrixArray2.GetLength(0); i++)
    {
        for (int j = 0; j <  MatrixArray2.GetLength(1); j++)
        {
             MatrixArray2[i, j] = new Random().Next(1, 10);
        }
    }
    return  MatrixArray2;
}

int[,] MultiplicationMatrices(int[,] MatrixArray1, int[,] MatrixArray2)
{
    int[,] MultiplicationMatrix = new int[2, 2];

    for (int i = 0; i < MultiplicationMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MultiplicationMatrix.GetLength(1); j++)
        {
           for (int m = 0; m < MultiplicationMatrix.GetLength(1); m++)
           {
            MultiplicationMatrix[i, j] += MatrixArray1[i, m]*MatrixArray2[m, j];
           }
        }
    }
return MultiplicationMatrix;
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

int[,] matr1 = Matrix1(2, 2);
PrintArray(matr1);
Console.WriteLine();
int[,] matr2 = Matrix2(2, 2);
PrintArray(matr2);
Console.WriteLine();
int[,] matr3 = MultiplicationMatrices(matr1, matr2);
PrintArray(matr3);
