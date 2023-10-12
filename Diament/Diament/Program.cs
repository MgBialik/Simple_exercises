Console.WriteLine("Podaj liczbę naturalną nieparzystą, która oznacza gługość krótszej przekątnej diamentu.");
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

    if (warunek && (number <= 0 || number % 2 == 0))
    {
        Console.Write("Podaj liczbę nieparzystą większą od zera! \r\n ");
        number_read = Console.ReadLine();
        number = Int32.Parse(number_read);
    }

} while (!warunek || number <= 0 || number % 2 == 0);

number = Int32.Parse(number_read);

string output = "";


string[] Diamond = new string[number / 2 + 1];

for (int i = 1; i <= number; i++)
{

    if (i <= number / 2 + 1)
    {
        string outputSpace = "";
        string outputStars = "";

        for (int j = (number - i); j > 0; j--)
        {
            outputSpace = outputSpace + " ";
        }

        for (int k = 1; k <= 2 * i - 1; k++)
        {
            outputStars = outputStars + "*";
        }


        output = outputSpace + outputStars;
        Console.WriteLine(output);
        Diamond[i - 1] = output;
        output = "";

    }
    else
    {

        {
            output = Diamond[number - i];
            Console.WriteLine(output);
        }


    }

}
