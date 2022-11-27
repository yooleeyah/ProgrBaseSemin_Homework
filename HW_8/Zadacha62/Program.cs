﻿void FillArraySpirally(int[,] array)
{
    int number = 1;
    int i = 0, j = 0;
    while (number <= array.GetLength(0) * array.GetLength(1))
    {
        array[i,j] = number;
        if ((i <= j + 1) && (i + j < array.GetLength(1) - 1)) j++;
        else if ((i < j) && (i + j >= array.GetLength(0) - 1)) i++;
            else if ((i >= j) && (i + j > array.GetLength(1) - 1)) j--;
                else i--;
        number++;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (array[i,j] < 10) Console.Write($"0{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = new int[4,4];
FillArraySpirally(array);
PrintArray(array);