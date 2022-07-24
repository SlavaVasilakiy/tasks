Console.Clear();

int numberA = 0;

Console.Write("Введите число ");
numberA = int.Parse(Console.ReadLine());

for (int x = 2; x <= numberA; x++)
  if (x % 2 == 0)
    Console.Write($"{x} ");