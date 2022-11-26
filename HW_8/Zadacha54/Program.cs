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

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 1; j < array.GetLength(1); j++) 
            {
                if (array[i,j] > array[i,j-1]) 
                {
                    int temp = array[i,j-1];
                    array[i,j-1] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
        
    }
}

int[,] array = new int[3,4];
FillArray(array);
PrintArray(array);
SortRows(array);
PrintArray(array);