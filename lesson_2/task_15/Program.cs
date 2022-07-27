// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи день недели в числовом виде: ");
int day = int.Parse(Console.ReadLine()!);

void CheckDay(int day)
{
  if (day == 6 || day == 7) Console.WriteLine($"{day} Выходной");
  else Console.WriteLine($"{day} Не выходной");
}

CheckDay(day);