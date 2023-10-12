
int helper = 0;
int numberOfPrimeNumbaers = 0;

for (int i = 0; i <= 100; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if ((i % j) == 0)
        { helper++; }
    }
    if (helper == 2)
    {
        Console.WriteLine(i);
        numberOfPrimeNumbaers++;
    }
    helper = 0;
}


Console.WriteLine("Liczb pierwszych w zakresie 0-100 jest: " + numberOfPrimeNumbaers);
