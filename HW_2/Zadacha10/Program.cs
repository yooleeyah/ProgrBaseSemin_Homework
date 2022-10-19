Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int second = (number/10) % 10;
Console.WriteLine(second);