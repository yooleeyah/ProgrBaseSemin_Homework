void FindSum(int m, int n, int sum)
{
    if (n == m) Console.Write(sum);
    else 
    {
        sum += n;
        FindSum(m, n - 1, sum);
    }
}

int m = 3;
int n = 11;
int sum = m;
FindSum(m, n, sum);