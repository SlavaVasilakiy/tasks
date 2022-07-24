Console.Clear();

int numberA = 0;

Console.Write("Введите число ");
numberA = int.Parse(Console.ReadLine());

if (numberA % 2 == 0)
{
  Console.Write($"Число {numberA} четное");
}
else
{
  Console.Write($"Число {numberA} нечетное");
}