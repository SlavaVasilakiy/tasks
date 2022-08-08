// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

Console.WriteLine();



NewArray(array);
PrintArray(array);

void MaxToMinArray(int[,] array)
    {
    for(int i = 0;i < m;i++)
        {
        for(int j = 0;j < n;j++)
            {
            for(int k = 0;k < n - 1;k++)
                {
                if(array[i, k] < array[i, k + 1])
                    {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                    }
                }
            }
        }
    return;
    }

Console.WriteLine();
MaxToMinArray(array);
PrintArray(array);

Console.ReadKey();
