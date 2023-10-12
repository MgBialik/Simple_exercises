Console.WriteLine("Podaj twój wzrost w centymetrach, a powiem Ci kilka 'miłych' słów.");
string high_read = Console.ReadLine();

bool warunek;
double high;
do
{
    warunek = double.TryParse(high_read, out high);
    if (!warunek)
    {
        Console.WriteLine("Podaj poprawne dane!");
        high_read = Console.ReadLine();

    }
} while (!warunek);

high = double.Parse(high_read);

if (high <= 0)
{
    Console.WriteLine("Podaj poprawny wzrost.");
}
else
{
    if (high > 0 && high <= 150)
    {
        Console.WriteLine("Jesteś jak dziecko.");
    }
    if (high > 150 && high <= 165)
    {
        Console.WriteLine("Powiedzmy, że jesteś średniego wzrostu.");
    }
    if (high > 165 && high <= 175)
    {
        Console.WriteLine("Już nieźle podrosłeś.");
    }
    if (high > 175 && high <= 190)
    {
        Console.WriteLine("Ale jesteś wysoki.");
    }
    if (high > 190)
    {
        Console.WriteLine("Chodzisz z głową w chmurach.");
    }
}
