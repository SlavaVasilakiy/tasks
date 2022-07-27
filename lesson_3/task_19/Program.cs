//  Задача 19

//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//  14212 -> нет

//  12821 -> да

//  23432 -> да

Console.WriteLine("Введите пятизначное число");

string user = Console.ReadLine()!;

void IsPal(string user)
{
  if (user[0] == user[4] && user[1] == user[3]) Console.WriteLine($"Число {user} палиндром");
  else Console.WriteLine($"Число {user} Не палиндром");
}

IsPal(user);

