double GetMaxValue(double[] arr)
{
    double maxNumb = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > maxNumb) maxNumb = arr[i];
    }
    return maxNumb;
}

double GetMinValue(double[] arr)
{
    double minNumb = 1;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] < minNumb) minNumb = arr[i];
    }
    return minNumb;
}

double[] array = new double[10];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().NextDouble() * new Random().Next(1,10);
    Console.Write($"{Math.Round(array[i],3)}, ");
}

Console.WriteLine();
double maxResult = GetMaxValue(array);
Console.WriteLine($"max = {Math.Round(maxResult, 3)}");
double minResult = GetMinValue(array);
Console.WriteLine($"min = {Math.Round(minResult, 3)}");
Console.WriteLine($"Разница = {Math.Round(maxResult - minResult, 3)}");