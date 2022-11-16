Console.WriteLine("Введите k1, b1, k2, b2 через Enter:");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine($"Прямые параллельны, точки пересечения нет.");
else
{
    int x = (b2 - b1)/(k1 - k2);
    int y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения - ({x},{y})");
}