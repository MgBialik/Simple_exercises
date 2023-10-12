Console.WriteLine("Podaj temperaturę powietrza.");
Console.Write("Temperatura = ");
string temperature_read = Console.ReadLine();

bool warunek;
double temperature;

do //sprawdzanie czy zczytana zmienna jest liczbą
{
    warunek = Double.TryParse(temperature_read, out temperature);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n Temperatura = ");
        temperature_read = Console.ReadLine();

    }
} while (!warunek);

temperature = Double.Parse(temperature_read);

switch (temperature)
{
    case < 0:
        Console.WriteLine("Strasznie piździ");
        break;
    case >= 0 when temperature < 10:
        Console.WriteLine("Zimno");
        break;
    case >= 10 when temperature < 20:
        Console.WriteLine("Chłodno");
        break;
    case >= 20 when temperature < 30:
        Console.WriteLine("W sam raz");
        break;
    case >= 30 when temperature < 40:
        Console.WriteLine("Zaczyna być słabo, bo gorąco");
        break;
    case >= 40:
        Console.WriteLine("Wyprowadzam się na Alaskę");
        break;
};