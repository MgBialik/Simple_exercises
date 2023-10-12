Console.WriteLine("Trzecie potęgi liczb z przedziału 1-20");

double thirdPower = 0;

for (int i = 1; i <= 20; i++)
{
    thirdPower = Math.Pow(i, 3);
    Console.WriteLine(thirdPower);
}