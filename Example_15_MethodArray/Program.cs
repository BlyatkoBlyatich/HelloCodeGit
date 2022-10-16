int[] array = {12,63,45,62,7189,42,566, 566};

int n = array.Length; // возвращает количество элементов массива
int find = 566;

int index = 0; //счетчик индекса

while(index < n)
{
    
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
