/* Максимальное число из 9 с помощью функции*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int a1 = 332;
int b1 = 234;
int c1 = 44;
int a2 = 55; 
int b2 = 66;
int c2 = 12;
int a3 = 66;
int b3 = 777777777;
int c3 = 2;

/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
*/

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c3),
    Max(a3, b3, c3));



Console.WriteLine(max);


