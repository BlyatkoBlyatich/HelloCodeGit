int[] numbers = {1, 8, 3, 2, 6};
int i = 0;
int max = numbers [0];
int size = 5;

while (i < size)
{
    if (numbers[i] > max)
    {
    max = numbers[i];
    }
    i = i + 1;
}
Console.WriteLine(max);