// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

Console.Write("Введите число, которое будем возводить в степень: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число в степень которого нужного возвести: ");
int num2 = int.Parse(Console.ReadLine()!);

int Step(int n1, int n2)
{
  int result = 1;
  for (int i = 1; i <= n2; i++)
  {
    result *= n1;
  }
  return result;
}

int answer = Step(num1, num2);

Console.WriteLine($"{num1} в {num2} степени = {answer}");