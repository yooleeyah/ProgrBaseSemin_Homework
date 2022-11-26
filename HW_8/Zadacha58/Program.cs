void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i,j] = new Random().Next(1,5);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] resultMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++) resultMatrix[i,j] += array1[i,k] * array2[k,j];
            }
        }
    return resultMatrix;
}

int[,] matrix1 = new int[2,2];
FillArray(matrix1);
int[,] matrix2 = new int[2,2];
FillArray(matrix2);
Console.WriteLine("Первая матрица: ");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);
Console.WriteLine("Произведение матриц: ");
PrintArray(MatrixMultiplication(matrix1, matrix2));