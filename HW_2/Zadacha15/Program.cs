Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7) Console.WriteLine("Такого дня недели не существует.");
else
{
    if (number == 6 || number == 7) Console.WriteLine("Выходной");
    else Console.WriteLine("Не выходной");
}