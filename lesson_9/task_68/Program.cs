/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 29 


ОПЯТЬ НЕ ПРАВИЛЬНЫЙ ОТВЕТ В ЗАДАЧЕ !!! СНОВА ГОЛОВУ ЛОМАЛ ЧТО НЕ ТАК С МОИМ КОДОМ )))*/

Console.Write("Введите m: ");
int m = 0;
int.TryParse(Console.ReadLine(), out m);

Console.Write("Введите n: ");
int n = 0;
int.TryParse(Console.ReadLine(), out n);

int function = A(m, n);

int A(int m, int n)
{
  if (m == 0)
        {
                return n + 1;
        } 
  else if (n == 0)
        {
                return A(m - 1, 1);
        }
  else
        {
                return A(m - 1, A(m, n - 1));
        }

}

Console.Write($"A(m, n) = {function} ");

Console.ReadKey();