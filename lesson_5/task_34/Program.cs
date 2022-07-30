// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] userN = new int[4];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max);
  }
  return;
}

void WriteArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
  return;
}

int Result(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

FillArray(userN, 100, 300);
WriteArray(userN);
Console.WriteLine();

int count = Result(userN);
Console.WriteLine($"--> {count}");