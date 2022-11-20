void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i,j] = new Random().Next(-100,100);
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i,j]}  ");
        Console.WriteLine();
    }
}

int[,] array = new int [3,6];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите строку и столбец искомого элемента через Enter:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m > array.GetLength(0) || n > array.GetLength(1)) Console.WriteLine("В массиве нет такого элемента.");
else Console.WriteLine(array[m - 1,n - 1]);