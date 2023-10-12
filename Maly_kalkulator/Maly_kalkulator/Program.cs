using Maly_kalkulator;

Console.WriteLine("Podaj dwie liczby.");
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


b = Double.Parse(b_read);
a = Double.Parse(a_read);

Console.Write("Podaj numer operacji do wykonania \r\n 1. Dodawanie \r\n 2.Odejmowanie \r\n 3.Mnożenie \r\n 4.Dzielenie \r\n Wybierasz: ");
string chosen_read = Console.ReadLine();

warunek = true;
do
{
    if (chosen_read != "1" && chosen_read != "2" && chosen_read != "3" && chosen_read != "4")
    {
        Console.WriteLine("Podana wartość jest nieprawidłowa. Spróbuj jeszcze raz.");
        chosen_read = Console.ReadLine();
    }
    else
    {
        warunek = false;
    }
} while (warunek);


int chosen = Int32.Parse(chosen_read);
Count Count = new Count();
double result = 0;

switch (chosen)
{

    case 1:
        result = Count.Addition(a, b);
        break;
    case 2:
        result = Count.Substraction(a, b);
        break;
    case 3:
        result = Count.Multiplication(a, b);
        break;
    case 4:
        if (b == 0)
        {
            Console.WriteLine("Wykonanie dzielenia jest niemożliwe - dzielenie przez 0.");
        }
        else
        {
            result = Count.Division(a, b);
        }
        break;

}

if (chosen != 4 || b != 0)
{
    string resultStr = result.ToString();
    Console.WriteLine($"Twój wynik to: {resultStr}");
}
