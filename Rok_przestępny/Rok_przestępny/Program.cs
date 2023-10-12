Console.WriteLine("Podaj dowolny rok. Sprawdzę, czy jest on przestępny.");
string year_read = Console.ReadLine();

bool warunek;
int year;
do
{
    warunek = Int32.TryParse(year_read, out year);
    if (!warunek)
    {
        Console.WriteLine("Podaj poprawne dane!");
        year_read = Console.ReadLine();

    }
} while (!warunek);

year = Int32.Parse(year_read);

int tryYear = year % 4;

if (tryYear == 0)
{
    Console.WriteLine($"Rok {year} jest rokiem przestępnym.");
}
else
{
    Console.WriteLine($"Rok {year} nie jest rokiem przestępnym.");
}