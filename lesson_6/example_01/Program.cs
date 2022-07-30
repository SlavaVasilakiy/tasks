// **Задача 40:**Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// <aside>
// ❗ **Теорема о неравенстве треугольника:**каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите сторону а:");
int userEnter1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону b:");
int userEnter2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону c:");
int userEnter3 = int.Parse(Console.ReadLine());

int max = userEnter1;
if (userEnter2 >= max)
{
  max = userEnter2;
}
if (userEnter3 > max)
{
  max = userEnter3;
}

int p = userEnter1 + userEnter2 + userEnter3;

int userEnterRes = p - max;

Console.WriteLine($"p = {p}");
Console.WriteLine($"max = {max}");

if (userEnterRes > max)
{
  Console.WriteLine($"Такой треугольник может существовать");
}
else
{
  Console.WriteLine($"Такой треугольник существовать не может");
}
