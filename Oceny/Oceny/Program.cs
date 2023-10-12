Console.WriteLine("Podaj liczbę naturalną z przedziału <1,6> jako ocenę ucznia");
string mark_read = Console.ReadLine();
bool warunek = true;

do
{
    if (mark_read != "1" && mark_read != "2" && mark_read != "3" && mark_read != "4" && mark_read != "5" && mark_read != "6")
    {
        Console.WriteLine("Podana wartość jest nieprawidłowa. Spróbuj jeszcze raz.");
        mark_read = Console.ReadLine();
    }
    else
    {
        warunek = false;
    }
} while (warunek);


int mark = Int32.Parse(mark_read);

string[] descriptiveMark = { "Niedostateczny", "Dopuszczający", "Dostateczny", "Dobry", "Bardzo dobry", "Celujący" };

Console.WriteLine(descriptiveMark[(mark - 1)]);
