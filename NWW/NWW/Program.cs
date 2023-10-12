using System;

Console.WriteLine("Podaj dwie liczby naturalne, a program zwróci najmniejszą wspólną wielokrotność.");
Console.Write("a = ");
string a_read = Console.ReadLine();

bool warunek;
int a;
do
{
    warunek = Int32.TryParse(a_read, out a);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n a = ");
        a_read = Console.ReadLine();

    }
} while (!warunek);

Console.Write("b = ");
string b_read = Console.ReadLine();
int b;
do
{
    warunek = Int32.TryParse(b_read, out b);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n b = ");
        b_read = Console.ReadLine();
    }
} while (!warunek);


b = Int32.Parse(b_read);
a = Int32.Parse(a_read);

Console.WriteLine(NWW(a, b));


int NWD(int a, int b)
{
    int helper = b;
    while (b != 0)
    {
        helper = b;
        b = a % b;
        a = helper;
    }

    return a;
}

int NWW(int a, int b)
{
    int helper;
    helper = a / NWD(a, b) * b;
    return helper;
}