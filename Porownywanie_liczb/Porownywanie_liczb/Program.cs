
Console.WriteLine("Podaj dwie liczby całkowite, które mam porównać.");
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

a = Int32.Parse(a_read);
b = Int32.Parse(b_read);

if (a == b)
{
    Console.WriteLine("Liczby są równe.");
}
else
{
    Console.WriteLine("Liczby nie są równe.");
}
