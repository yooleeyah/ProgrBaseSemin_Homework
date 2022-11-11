Console.Write("Введите число, которое нужно возвести в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень нужно возвести: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int exponent = 1;
for (int i = 1; i <= numberB; i++) exponent *= numberA;
Console.WriteLine(exponent);