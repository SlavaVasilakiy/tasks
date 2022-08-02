Console.Clear();

int numberA = 0;
int numberB = 0;
int numberC = 0;
int max = numberA;

Console.Write("Введите первое число ");
numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
numberB = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число ");
numberC = int.Parse(Console.ReadLine()!);

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write($"Максимальное число {max}");