void FillArray(int[,,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++) 
            {
                temp = new Random().Next(10,100);
                if (Contains(array, temp) == true) k--;
                else array[i,j,k] = temp;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++) Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

bool Contains(int[,,] arr, int a)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {       
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            for (int k = 0; k < arr.GetLength(2); k++) if (arr[i,j,k] == a) return true;
        }
    }
    return false;
}

int[,,] array = new int[2,2,2];
FillArray(array);
PrintArray(array);