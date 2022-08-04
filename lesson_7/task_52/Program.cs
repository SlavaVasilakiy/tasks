// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(20);
        }
    }
    return;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(string.Format("{0,3} ", array[i, j] + ""));
        }
        Console.WriteLine();
    }
    return;
}

void SumAverage(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        double sumAvg = 0;
        for (int j = 0; j < m; j++)
        {
            sumAvg = sumAvg + array[j, i];
        }
        sumAvg = Math.Round(sumAvg / m, 1);
        Console.Write($"Столбец {i + 1}) {sumAvg}   ");
    }
    return;
}

NewArray(array);
PrintArray(array);
Console.WriteLine();
SumAverage(array);
