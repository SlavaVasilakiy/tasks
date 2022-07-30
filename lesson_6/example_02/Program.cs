// **Задача 42:**Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

Console.WriteLine("Введите число: ");
int userEnter1 = int.Parse(Console.ReadLine()!);

string st(int a)
{
  string str = "";
  while (a > 0)
  {
    int b = 0;
    b = a % 2;
    a = a / 2;
    str = b + str;
  }
  return str;
}

Console.WriteLine($"{st(userEnter1)}");