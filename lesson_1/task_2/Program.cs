Console.Clear();

int numberA = 0;
int numberB = 0;
//int max = 0;
//int min = 0;

Console.Write("Введите первое число ");
numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)

{
  // max = numberA;
  // min = numberB;
  Console.Write($"{numberA} больше, чем {numberB}");
}
else
{
  //max = numberB;
  //min = numberA;
  Console.Write($"{numberB} больше, чем {numberA}");
}

//Console.Write($"{max} больше, чем {min}");

