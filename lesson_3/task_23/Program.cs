// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");

int userN = int.Parse(Console.ReadLine()!);

void Result(int[] userN)
{
  int counter = 1;
  int length = userN.Length;
  while (counter < length)
  {
    userN[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void Print(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while (index < count)
  {
    Console.Write(coll[index] + " ");
    index++;
  }
}

int[] a = new int[userN + 1];
Result(a);
Print(a);