// создание массива введеного пользователем с консоли

Console.Write($"Введите размер массива: ");

int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

int i = 0;

while (i < size)
{
  Console.Write($"Введите [{i}] элемент: ");
  int temp = int.Parse(Console.ReadLine());
  array[i] = temp;
  i++;
}

for (int j = 0; j < size; j++)
  Console.Write($"{array[j]}");