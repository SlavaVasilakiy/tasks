// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1, 100);
  Console.Write($"{array[i]} ");
}

int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
  if (max < array[i]) max = array[i];

  if (min > array[i]) min = array[i];
}

int result = max - min;
Console.WriteLine();
Console.WriteLine($"{max} - {min} = {result}");