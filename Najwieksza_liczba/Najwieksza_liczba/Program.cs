using System.ComponentModel.DataAnnotations;

Console.WriteLine("Podaj trzy dowolne liczby, które mam porównać.");
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

a = Double.Parse(a_read);
b = Double.Parse(b_read);
c = Double.Parse(c_read);

double max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Największą liczbą jest {max}");