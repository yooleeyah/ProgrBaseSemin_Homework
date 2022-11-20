void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i,j] = new Random().Next(0,100);
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i,j]}   ");
        Console.WriteLine();
    }
}

void ColumnsArithmeticMean (int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        float sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) sum += array[i,j];
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца: {Math.Round(sum/array.GetLength(0), 2)}");
    }
}

Console.WriteLine("Введите число строк и столбцов через Enter:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
FillArray(array);
PrintArray(array);
ColumnsArithmeticMean(array);