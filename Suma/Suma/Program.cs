Console.WriteLine("Suma wg. wzoru 1+1/2+1/3+1/4+... dla liczb z przedziału 1-20");

double sum = 0;
for (double i = 1; i <= 20; i++)
{
    sum = sum + (1 / i);

}

Console.WriteLine(sum);


