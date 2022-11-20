void FillArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i,j] = new Random().NextDouble() * new Random().Next(-100,100);
    }
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{Math.Round(array[i,j], 2)}   ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк и столбцов через Enter:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [m,n];
FillArray(array);
PrintArray(array);