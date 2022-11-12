double[] array = new double[4];
double maxNumb = 0;
double minNumb = 1;
for (int i = 0; i < 4; i++) 
{
    array[i] = new Random().NextDouble();
    Console.Write($"{array[i]}, ");
    if (array[i] > maxNumb) maxNumb = array[i];
    if (array[i] < minNumb) minNumb = array[i];
}
 Console.WriteLine();
 Console.WriteLine($"max = {maxNumb}");
 Console.WriteLine($"min = {minNumb}");
 Console.WriteLine($"Разница = {maxNumb - minNumb}");