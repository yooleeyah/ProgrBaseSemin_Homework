int[] array = new int[4];
int sum = 0;
for (int i = 0; i < 4; i++) 
{
    array[i] = new Random().Next(-10,100);
    Console.Write($"{array[i]}, ");
    if (i % 2 != 0) sum += array[i];
}
Console.WriteLine();
Console.WriteLine(sum);