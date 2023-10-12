
Console.WriteLine("Podaj liczbę całkowitą do sprawdzenia jej parzystości.");
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
int b = a % 2;

if (b == 0)
{
    Console.WriteLine("Liczba jest parzysta."); // zero podobno jest teź parzyste
}
else
{
    Console.WriteLine("Liczba jest nieparzysta.");
}
