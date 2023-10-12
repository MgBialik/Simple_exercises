Console.WriteLine("Podaj Twoje wyniki maturalne z matematyki, fizyki i chemii (procentowo 0-100).");
Console.Write("Matematyka = ");
string math_read = Console.ReadLine();

bool warunek;
double math;

do //sprawdzanie czy zczytana zmienna jest liczbą
{
    warunek = Double.TryParse(math_read, out math);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n Matematyka = ");
        math_read = Console.ReadLine();

    }
} while (!warunek);

math = Double.Parse(math_read);

do  //sprawdzanie czy zczytana zmienna jest liczbą w przedziale <0,100> - moje założenie, że to są procentowe wyniki z matury, które mogą być ułamkami, nie wynika to z zadania
{
    if (math < 0 || math > 100)
    {
        Console.Write("Podaj poprawne dane! \r\n Matematyka = ");
        math_read = Console.ReadLine();
        math = Double.Parse(math_read);
    }


} while (math < 0 || math > 100);

Console.Write("Fizyka = ");
string phisics_read = Console.ReadLine();
double phisics;
do
{
    warunek = Double.TryParse(phisics_read, out phisics);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n Fizyka = ");
        phisics_read = Console.ReadLine();
    }
} while (!warunek);

phisics = Double.Parse(phisics_read);

do
{
    if (phisics < 0 || phisics > 100)
    {
        Console.Write("Podaj poprawne dane! \r\n Fizyka = ");
        phisics_read = Console.ReadLine();
        phisics = Double.Parse(phisics_read);
    }


} while (phisics < 0 || phisics > 100);


Console.Write("Chemia = ");
string chemistry_read = Console.ReadLine();
double chemistry;
do
{
    warunek = Double.TryParse(chemistry_read, out chemistry);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n Chemia = ");
        chemistry_read = Console.ReadLine();
    }
} while (!warunek);

chemistry = Double.Parse(chemistry_read);

do
{
    if (chemistry < 0 || chemistry > 100)
    {
        Console.Write("Podaj poprawne dane! \r\n Chemia = ");
        chemistry_read = Console.ReadLine();
        chemistry = Double.Parse(chemistry_read);
    }


} while (chemistry < 0 || chemistry > 100);


double sumMPCH = math + phisics + chemistry;
double sumMP = math + phisics;
double sumMCH = math + chemistry;

if (math > 70 && phisics > 55 && chemistry > 45 && sumMPCH > 180)
{
    Console.WriteLine("Gratulacje! Dostałeś się na studia.");
}
else if (sumMP > 150 || sumMCH > 150)
{
    Console.WriteLine("Gratulacje! Dostałeś się na studia.");
}
else
{
    Console.WriteLine("Bardzo nam przykro. Nie dostałeś się na studia.");
}