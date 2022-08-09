/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1;
N = 15-> 120
M = 4;
N = 8. -> 30*/

Console.Write("Введите начальную цифру: ");
int m = 0;
int.TryParse(Console.ReadLine(), out m);

Console.Write("Введите конечную цифру: ");
int n = 0;
int.TryParse(Console.ReadLine(), out n);

int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

string PrintNumbers(int m, int n)
{
    if (m == n) 
        return m.ToString();
     return (m + " " + PrintNumbers(m + 1, n));
}

Console.Write(PrintNumbers(m, n));
Console.WriteLine();

void SumNumbers(int m, int n, int sum)
    {
    sum += n;
        if (n <= m)
        {
        Console.Write($"Сумма = {sum}");
        return;
        }
        SumNumbers(m, n - 1, sum);
    }

SumNumbers(m,n,temp=0);

Console.ReadKey();