int[] array = new int[8];
Console.WriteLine("Введите 8 элементов массива через Enter");
for (int i = 0; i < 8; i++) array[i] = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 8; i++) Console.Write($"{array[i]}, ");
