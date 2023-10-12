using System;

Console.WriteLine("Podaj wymiary 3 odcinków, a sprawdzę, czy można z nich zbudować trójkąt.");
Console.Write("a = ");
string a_read = Console.ReadLine();

bool warunek;
double a;
do
{
    warunek = Double.TryParse(a_read, out a);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n a = ");
        a_read = Console.ReadLine();

    }
} while (!warunek);

a = Double.Parse(a_read);

do
{
    if (a <= 0)
    {
        Console.Write("Długość odcinka musi być większa od zera! \r\n a = ");
        a_read = Console.ReadLine();
        a = Double.Parse(a_read);
    }


} while (a <= 0);




Console.Write("b = ");
string b_read = Console.ReadLine();
double b;
do
{
    warunek = Double.TryParse(b_read, out b);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n b = ");
        b_read = Console.ReadLine();
    }
} while (!warunek);


b = Double.Parse(b_read);

do
{
    if (b <= 0)
    {
        Console.Write("Długość odcinka musi być większa od zera! \r\n b = ");
        b_read = Console.ReadLine();
        b = Double.Parse(b_read);
    }


} while (b <= 0);


Console.Write("c = ");
string c_read = Console.ReadLine();
double c;
do
{
    warunek = Double.TryParse(c_read, out c);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n c = ");
        c_read = Console.ReadLine();
    }
} while (!warunek);


c = Double.Parse(c_read);

do
{
    if (c <= 0)
    {
        Console.Write("Długość odcinka musi być większa od zera! \r\n c = ");
        c_read = Console.ReadLine();
        c = Double.Parse(a_read);
    }


} while (c <= 0);


double max = a;
double min = a;
double average = a;

if (a >= b && a >= c)
{
    max = a;
}
else if (a <= b && a <= c)
{
    min = a;
}
else
{
    average = a;
};

if (b >= a && b >= c)
{
    max = b;
}
else if (b <= a && b <= c)
{
    min = b;
    average = b;
}
else
{
    average = b;
};
if (c >= a && c >= b)
{
    max = c;
}
else if (c <= a && c <= b)
{
    min = c;
}
else
{
    average = c;
};

//Console.WriteLine($"max = {max}");
//Console.WriteLine($"aver = {average}");
//Console.WriteLine($"min = {min}");


if ((min + average) > max)
{
    Console.WriteLine("Utworzenie trójkąta z danych odcinków jest możliwe.");
}
else { Console.WriteLine("Utworzenie trójkąta z danych odcinków nie jest możliwe."); };

