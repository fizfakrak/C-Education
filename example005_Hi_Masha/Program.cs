﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА, это Маша!");
}
else
{
    Console.Write("Хай, ");
    Console.WriteLine(username);
}