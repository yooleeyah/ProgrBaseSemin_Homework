﻿Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"max = {number1}");
if (number1 <= number2) Console.WriteLine($"max = {number2}");
