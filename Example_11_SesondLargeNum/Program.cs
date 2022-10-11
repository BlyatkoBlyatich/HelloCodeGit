int [] numbers = {3, 20, 18, 103, 92}; // программма находит второе по величине число
int size = 5, current_i = 0,
max_number_i = 0, max = numbers[0],
temp = 0;

while (current_i < size)
{
    if (numbers[current_i]>max)
    {
        temp = max;
        max = numbers[current_i];
        max_number_i = current_i;
    }
    else
    {
        if (numbers[current_i] > temp)
        {
            temp = numbers[current_i];
        }
           
    }
    current_i = current_i + 1;
}
Console.WriteLine (max);
Console.WriteLine (temp);