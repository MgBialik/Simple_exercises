
Console.WriteLine("Podaj liczbę całkowitą. Sprawdzę, czy jest dodatnia czy ujemna.");
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

a = Int32.Parse(a_read);

switch (a)
{
    case 0:
        Console.WriteLine("Podałeś liczbę 0. Nie jest ona dodatnia ani ujemna.");
        break;
    case > 0:
        Console.WriteLine("Liczba jest większa od zera.");
        break;
    case < 0:
        Console.WriteLine("Liczba jest mniejsza od zera.");
        break;
}
