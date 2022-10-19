Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
if (number > 99 && number < 1000) Console.WriteLine(number % 10);
if (number > 999) 
{
    while (number > 1000) number = number / 10;
    Console.WriteLine(number % 10);
}