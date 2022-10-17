Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Число должно быть положительным.");
if (number == 1) Console.WriteLine("Чётных чисел нет.");

Console.Write("Чётные числа: ");
int i = 2;
while (i < number) 
{
    Console.Write($"{i}, ");
    i += 2;
}
if (i == number) Console.Write($"{i}.");