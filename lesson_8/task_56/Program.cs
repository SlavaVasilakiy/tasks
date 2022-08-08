/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


Console.Write("Введите количество строк: ");
int m = 0;
int.TryParse(Console.ReadLine(), out m);

Console.Write("Введите количество столбцов: ");
int n = 0;
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];
Console.WriteLine();

void NewArray(int[,] array)
    {
    for(int i = 0;i < m;i++)
        {
        for(int j = 0;j < n;j++)
            {
            array[i, j] = new Random().Next(10);
            }
        }
    return;
    }

void PrintArray(int[,] array)
    {
    for(int i = 0;i < m;i++)
        {
        for(int j = 0;j < n;j++)
            {
            Console.Write(string.Format("{0,3} ", array[i, j] + ""));
            }
        Console.WriteLine();
        }
    return;
    }

NewArray(array);
PrintArray(array);

int SumArrayLine(int[,] array, int i)
    {
    int sum = array[i, 0];
    for(int j = 1;j < n;j++)
        {
        sum += array[i, j];
        }
    return sum;
    }

int minLine = 0;
int minSum = SumArrayLine(array, 0);
for(int i = 1;i < m;i++)
    {
    int tempSumLine = SumArrayLine(array, i);
    if(minSum > tempSumLine)
        {
        minSum = tempSumLine;
        minLine = i;
        }
    }

Console.WriteLine($"\nМинимальная сумма {minSum} в {minLine+1} строке");
Console.ReadKey();
