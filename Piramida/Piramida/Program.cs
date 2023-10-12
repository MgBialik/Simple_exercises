
using System.Threading;

Console.WriteLine("Podaj liczbę naturalną, która zakończy piramidę.");
string number_read = Console.ReadLine();
int number;

bool warunek;
do  //sprawdza czy zaczytane znaki są liczbą i czy są większe od zera
{
    warunek = Int32.TryParse(number_read, out number);
    if (!warunek)
    {
        Console.Write("Podaj poprawne dane! \r\n");
        number_read = Console.ReadLine();
    }

    if (warunek && number <= 0)
    {
        Console.Write("Podaj liczbę większą od zera! \r\n ");
        number_read = Console.ReadLine();
        number = Int32.Parse(number_read);
    }

} while (!warunek || number <= 0);

number = Int32.Parse(number_read);

Console.WriteLine();
int w = 1;
int n = 1;
string output = "";

while (n <= number)
{
    for (int i = 1; i <= n && w <= number; i++)
    {
        output = output + (w);
        w++;
    }

    Console.WriteLine(output);
    output = "";
    n++;
};
