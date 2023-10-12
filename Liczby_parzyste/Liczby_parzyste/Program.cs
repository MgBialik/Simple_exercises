
// Program wyświetla liczby parzyste w przedziale <0,1000>

int i = 0; //0 spełnia warunek liczby parzystej
int j = 0;

do
{
    j = i % 2;
    if (j == 0)
    {
        Console.WriteLine(i);
    }

    i++;

} while (i <= 1000);