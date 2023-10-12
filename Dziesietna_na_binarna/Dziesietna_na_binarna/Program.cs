Console.WriteLine("Podaj liczbę w systemie dziesiętnym, którą chcesz zamienić na binarną.");

string numberDec_read = Console.ReadLine();
int numberDec = Int32.Parse(numberDec_read);
int result = numberDec;
string numberBinOpposite = "";

do
{
    numberBinOpposite = numberBinOpposite + (result % 2).ToString();
    result = result / 2;

} while (result > 0);

int lenghtOfNumberBinOpposite = numberBinOpposite.Length;
string numberBin = "";

for (int i = (lenghtOfNumberBinOpposite - 1); i >= 0; i--)
{
    numberBin = numberBin + numberBinOpposite[i];
}

Console.WriteLine($"{numberDec} binarnie to {numberBin}");
