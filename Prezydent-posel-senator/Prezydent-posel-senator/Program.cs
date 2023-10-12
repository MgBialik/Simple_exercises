Console.WriteLine("Podaj twój wiek, a sprawdzę, czy możesz zostać posłem, senatorem, premierem lub prezydentem.");
string age_read = Console.ReadLine();

bool warunek;
int age;
do
{
    warunek = Int32.TryParse(age_read, out age);
    if (!warunek)
    {
        Console.WriteLine("Podaj poprawne dane!");
        age_read = Console.ReadLine();

    }
} while (!warunek);

age = Int32.Parse(age_read);
WishAge MyAge = new WishAge();
MyAge.posel = false;
MyAge.senator = false;
MyAge.prezydent = false;
MyAge.premier = false;
MyAge.komunikat = "Możesz zostać ";


if (age < 0)
{
    Console.WriteLine("Podaj poprawny wiek.");
}
else
{
    if (age < 21)
    {
        MyAge.komunikat = "Niestety jesteś zbyt młody by zostać posłem, senatorem, premierem lub prezydentem";
    }

    if (age >= 21)
    {
        MyAge.posel = true;
        MyAge.premier = true;
        MyAge.komunikat = MyAge.komunikat + "posłem i premierem (jeśli zyskasz poparcie)"; // premier nie posiada ograniczenia wiekowego, ale musi być posłem
    }

    if (age >= 30)
    {
        MyAge.senator = true;
        MyAge.komunikat = MyAge.komunikat + " oraz senatorem";
    }

    if (age >= 35)
    {
        MyAge.prezydent = true;
        MyAge.komunikat = MyAge.komunikat + ", a nawet prezydentem";
    }

    MyAge.komunikat = MyAge.komunikat + ".";
    Console.WriteLine(MyAge.komunikat);
}

public struct WishAge
{
    public bool posel; // bool trochę na wyrost, ale chciałam się pobawić
    public bool senator;
    public bool prezydent;
    public bool premier;
    public string komunikat;
}