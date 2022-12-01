void PrintNaturals(int n)
{
    if (n == 1) Console.Write($"{n} ");
    else 
    {
        Console.Write($"{n} ");
        PrintNaturals(n - 1);
    }
}

int n = 6;
PrintNaturals(n);