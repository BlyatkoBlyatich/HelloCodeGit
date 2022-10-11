int [] firstVector = {6,6};
int [] secondVector = {6,6};
int ScalarProd = 0;
int i = 0;
int size = 2;

while (i<size)
{
    ScalarProd = ScalarProd+firstVector[i]*secondVector[i];
    i = i + 1;
}
Console.WriteLine (ScalarProd);