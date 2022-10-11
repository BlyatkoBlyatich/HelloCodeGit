int count = 0, firstFriendSpeed = 1,
secondFriendSpeed = 2, dogSpeed = 5, 
friend = 2; // задали вводные данные

double time = 0, distance = 10000; // double поскольку деление не целочисленное

while (distance > 10)
{
    if (friend==1) 
    
    {
        time = distance/(firstFriendSpeed+dogSpeed);
        friend = 2;
    }
    
    else 
    
    {
        time = distance/(secondFriendSpeed+dogSpeed);
        friend = 1;
    }
    
    distance = distance - (firstFriendSpeed+secondFriendSpeed) * time;

    count++;

}
Console.WriteLine(count);

