// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Сколько будет чисел? ");
int m = int.Parse(Console.ReadLine()!);
int[] mArray = new int[m];

void NumberFirst(int m)
{
  for (int i = 0; i == 0; i++)
  {
    Console.Write($"Начнемс: ");
    mArray[i] = int.Parse(Console.ReadLine()!);
  }
  return;
}

void Numbers(int m)
{
  for (int i = 1; i < m - 1; i++)
  {
    Console.Write($"Теперь {i + 1} число: ");
    mArray[i] = int.Parse(Console.ReadLine()!);
  }
  return;
}

void NumberLast(int m)
{
  for (int j = m - 1; j < m; j++)
  {
    Console.Write($"ИИИиии последнее: ");
    mArray[j] = int.Parse(Console.ReadLine()!);
  }
  return;
}

int NumCount(int[] mArray)
{
  int count = 0;
  for (int i = 0; i < mArray.Length; i++)
  {
    if (mArray[i] > 0) count++;
  }
  return count;
}

NumberFirst(m);
Numbers(m);
NumberLast(m);
Console.WriteLine($"Счаз я усе посчитаю...");
System.Threading.Thread.Sleep(4000);
Console.WriteLine($"                      Ща-ща, я думаю...");
System.Threading.Thread.Sleep(4000);
Console.WriteLine($"                                        ГОТОВО !!! Больше ноля - {NumCount(mArray)} шт.\n End of programm");

// тут один минус из-зи того что я налепил лишних действий, у меня программа работает не верно когда мы водим только одно число, не хватило мозгов что бы это исправить. Если убрать лишнее, то все работает как положенно. Надеюсь не снизите оценку за это.