
// program wyświetla początkowe elementy ciągu Fibonacciego 
ulong periouspreviousN = 0; // (n-2) element ciągu 
ulong previousN = 1;  // (n-1) element ciągu
ulong item = 0;
Console.WriteLine(previousN);

for (int n = 2; n < 94; n++)  // 93-ci wyraz ciągu jest ostatnim poprawnym, potem wychodzimy poza skalę ulong
{
    item = periouspreviousN + previousN;
    Console.WriteLine(item);
    periouspreviousN = previousN;
    previousN = item;
}
