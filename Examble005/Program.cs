// Пример с ответвлениями
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Маша")
{
    Console.Write("Привет! Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}