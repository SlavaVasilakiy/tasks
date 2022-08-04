// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int m = 0;
int.TryParse(Console.ReadLine(), out m);

Console.Write("Введите количество столбцов: ");
int n = 0;
int.TryParse(Console.ReadLine(), out n);

double[,] array = new double[m, n];
Console.WriteLine();

void NewArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10000, 10000)) / 100;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(string.Format("{0,8} ", array[i, j] + ""));
        }
        Console.WriteLine();
    }
}

NewArray(array);
PrintArray(array);
Console.WriteLine();