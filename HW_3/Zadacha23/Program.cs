﻿void PrintSquareChart(int number)
{
    for (int i = 1; i <= number; i++) Console.Write($"{i*i*i}, ");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintSquareChart(number);