void FillArraySpirally(int[,] array)
{
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    int number = 1;
    int i = 0, j = 0;
    while (number <= array.GetLength(0) * array.GetLength(1))
    {
        array[i,j] = number;
        if (i == Ibeg && j < array.GetLength(1) - Jfin - 1) j++;
        else if (j == array.GetLength(1) - Jfin - 1 && i < array.GetLength(0) - Ifin - 1) i++;
            else if (i == array.GetLength(0) - Ifin - 1 && j > Jbeg) j--;
                else i--;
        if (( i == Ibeg + 1) && (j == Jbeg))
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
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