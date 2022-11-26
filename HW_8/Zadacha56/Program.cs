void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i,j] = new Random().Next(0,10);
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

int FindLeastSumRow(int[,] array)
{
    int minSum = 9999;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i,j];
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i+1;
        } 
    }
    return minRow;
}

int[,] array = new int[4,4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Строка с минимальной суммой элементов - {FindLeastSumRow(array)} строка.");