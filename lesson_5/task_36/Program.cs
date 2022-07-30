// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

Console.Write($"Длина массива?: ");
int userS = int.Parse(Console.ReadLine()!);

int FillsumArray(int userS, int min, int max)
{
  int[] rNum = new int[userS];
  int sum = 0;
  Console.Write("Массив: ");
  for (int i = 0; i < rNum.Length; i++)
  {
    rNum[i] = new Random().Next(min, max);
    Console.Write($"{rNum[i]} ");
    if (i % 2 == 0) // Если я правильно понял, то мы ищем именно позицию , которая начинается с 1 , а не индекс, который начинается с 0.
    {
      sum = sum + rNum[i];
    }
  }
  return sum;
}

int rNum = FillsumArray(userS, 1, 6);
Console.WriteLine($"\nСумма = {rNum}");