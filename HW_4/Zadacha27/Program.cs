Console.Write("Введите число: ");
int count = 1;
for (int number = Convert.ToInt32(Console.ReadLine()); (number/10) >= 1; number /= 10) count++;
Console.WriteLine($"Цифр в числе: {count}");