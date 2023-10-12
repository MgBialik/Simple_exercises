
Console.WriteLine("Podaj dowolny ciąg znaków. Jego kolejność zostanie odwrócona.");
string chain = Console.ReadLine();
int lenght = chain.Length;
string opposite = "";

for (int i = (lenght - 1); i >= 0; i--)
{
    opposite = opposite + chain[i];
}

Console.WriteLine(opposite);