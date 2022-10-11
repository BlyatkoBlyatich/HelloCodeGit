Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "василиса")
{
    Console.WriteLine("Ура, это же Василиса!");
}
else
{   
    Console.Write("Привет, полупокер по имени ");
    Console.WriteLine(username);
}