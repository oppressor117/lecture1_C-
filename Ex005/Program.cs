Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "евгения")
{
    Console.WriteLine("Ура, это же Евгения!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}