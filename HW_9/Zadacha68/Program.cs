int Ackermann (int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Ackermann (m - 1, 1);
        else if ((m > 0) && (n > 0)) return Ackermann (m - 1, Ackermann (m, n - 1));
            else return -1;
}

int m = 3; //не вводить больше 3!!!
int n = 4;
if (Ackermann(m, n) == -1) Console.WriteLine("Числа заданы неправильно.");
else Console.WriteLine(Ackermann(m, n));