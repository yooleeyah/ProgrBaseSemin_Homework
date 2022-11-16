Console.Write("Введите кол-во чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());
int posAmount = 0;
Console.WriteLine("Введите числа через Enter:");
for(int i = 0; i < amount; i++) 
{
    if(Convert.ToInt32(Console.ReadLine()) > 0) posAmount++;
}
Console.WriteLine(posAmount);