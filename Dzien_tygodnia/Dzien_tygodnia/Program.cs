Console.WriteLine("Podaj liczbę naturalną z przedziału <1,7> jako dzień tygodnia");
string day_read = Console.ReadLine();
bool warunek = true;

do
{
    if (day_read != "1" && day_read != "2" && day_read != "3" && day_read != "4" && day_read != "5" && day_read != "6" && day_read != "7")
    {
        Console.WriteLine("Podana wartość jest nieprawidłowa. Spróbuj jeszcze raz.");
        day_read = Console.ReadLine();
    }
    else
    {
        warunek = false;
    }
} while (warunek);


int day = Int32.Parse(day_read);

string[] descriptiveDay = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };

Console.WriteLine(descriptiveDay[(day - 1)]);
