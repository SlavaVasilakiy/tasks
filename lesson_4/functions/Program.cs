// Console.Write("Введите число ");
// string number = Console.ReadLine();
// int count = number.Length;
// Console.WriteLine(count);

// Console.Write("Введите число ");
// int number = int.Parse(Console.ReadLine());
// int count = 0;
// if (number == 0) count = 1;
// while (number != 0)
// {
//   number = number / 10;
//   count++;
// }
// Console.WriteLine(count);







// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120


Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);
ulong Mult(int number)
{
  ulong num = 1;
  for (uint i = 1; i <= number; i++)
  {
    num = num * i;
  }
  return num;
}
Console.WriteLine($"Произведение чисел от 1 до {number} равно {Mult(number)}");