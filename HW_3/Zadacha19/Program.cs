void PrintIfPolyndrom(int number)
{
    if ((number/10000) == (number % 10))
    {
        number = number/10;
        if (((number/100) % 10) == (number % 10)) Console.WriteLine("Число - палиндром.");
        else Console.WriteLine("Число - не палиндром.");
    }
    else Console.WriteLine("Число - не палиндром.");
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintIfPolyndrom(number);