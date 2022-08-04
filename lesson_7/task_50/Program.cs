// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17->такого числа в массиве нет

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

void FindNumber(int[,] array)
{
    Console.WriteLine("Введите индекс строки: ");
    int findM = 0;
    int.TryParse(Console.ReadLine(), out findM);

    Console.WriteLine("Введите индекс столбца: ");
    int findN = 0;
    int.TryParse(Console.ReadLine(), out findN);

    if (findM < m && findN < n)
    {
        Console.WriteLine($"Значение в индексе {findM},{findN} = {array[findM, findN]}");
    }
    else
    {
        Console.WriteLine($"Такого индекса в массиве нет!!!");
    }
    return;
}

NewArray(array);
PrintArray(array);
Console.WriteLine();
FindNumber(array);


