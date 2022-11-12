int[] array = new int[4];
int count = 0;
for (int i = 0; i < 4; i++) 
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]}, ");
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine();
Console.WriteLine(count);